using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entitys;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;

namespace logica
{
    public class UsuarioController:UsuarioBD
    {
        private UsuarioBD db = new UsuarioBD();
        public string RegistrarUsuario(string nombre, string email, string contraseña, string rol)
        {
            try
            {
                // Hashear la contraseña antes de guardarla
                string contraseñaHasheada = BCrypt.Net.BCrypt.HashPassword(contraseña);

                usuarioEntyti nuevoUsuario = new usuarioEntyti
                {
                    Nombre = nombre,
                    Email = email,
                    Contraseña = contraseñaHasheada,
                    Rol = rol
                };

                int resultado = db.GuardarUsuario(nuevoUsuario); // método que guarda en la BD

                if (resultado > 0)
                {
                    return "Usuario registrado exitosamente.";
                }
                else
                {
                    return "Error al registrar el usuario.";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }



        public string Login(string email, string contraseña, out string rol)
        {
            rol = "";

            try
            {
                usuarioEntyti usuario = db.BuscarUsuarioPorEmail(email);

                if (usuario != null && BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña))
                {
                    rol = usuario.Rol;
                    return "Inicio de sesión exitoso.";
                }
                else
                {
                    return "Correo o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

}

}
