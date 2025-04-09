using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entitys;

namespace logica
{
    public class UsuarioController:UsuarioBD
    {
        private UsuarioBD db = new UsuarioBD();
        public string RegistrarUsuario(string nombre, string email, string contraseña, string rol)
        {
            string contraseñaHash = Seguridad.HashPassword(contraseña); // Encriptar

            usuarioEntyti usuario = new usuarioEntyti
            {
                Nombre = nombre,
                Email = email,
                Contraseña = contraseñaHash,
                Rol = rol
            };

            int resultado = db.GuardarUsuario(usuario);

            return resultado > 0 ? "Usuario registrado con éxito" : "Error al registrar el usuario";
        }

        public string Login(string email, string contraseña)
        {
            var usuario = db.BuscarUsuarioPorEmail(email);

            if (usuario == null)
            {
                return "Usuario no encontrado";
            }

            // Comparar la contraseña en texto plano (si no hasheaste)
            if (usuario.Contraseña == contraseña)
            {
                return $"Bienvenido {usuario.Nombre}, Rol: {usuario.Rol}";
            }
            else
            {
                return "Contraseña incorrecta";
            }

            // Si usas BCrypt:
            // if (BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña)) { ... }
        }
    }

}

}
