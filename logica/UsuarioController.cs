using System;
using Modelo;
using Modelo.Entitys;
using BCrypt.Net;

namespace logica
{
    public class UsuarioController
    {
        private UsuarioBD db = new UsuarioBD();

        public string RegistrarUsuario(string nombre, string email, string contraseña, string rol)
        {
            try
            {
                string contraseñaHasheada = BCrypt.Net.BCrypt.HashPassword(contraseña);

                usuarioEntyti nuevoUsuario = new usuarioEntyti
                {
                    Nombre = nombre,
                    Email = email,
                    Contraseña = contraseñaHasheada,
                    Rol = rol
                };

                int resultado = db.GuardarUsuario(nuevoUsuario);

                return resultado > 0 ? "Usuario registrado exitosamente." : "Error al registrar el usuario.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public usuarioEntyti Login(string correo, string contraseña)
        {
            usuarioEntyti usuario = db.BuscarUsuarioPorEmail(correo);
            //secionActual.secion = usuario;

            if (usuario != null)
            {
                Console.WriteLine("Hash guardado: " + usuario.Contraseña);

                bool contraseñaValida = BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña);

                if (contraseñaValida)
                {
                    SesionActual.IniciarSesion(usuario); 
                    return usuario;
                }
                else
                {
                    Console.WriteLine("La contraseña no coincide.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró el usuario.");
            }


            return null;
        }

    }
}
