using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entitys;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace Modelo
{
    public class UsuarioBD:ConexionMsql
    {
        private ConexionMsql conexion = new ConexionMsql();

        public usuarioEntyti BuscarUsuarioPorEmail(string email)
        {
            using (var conexion = conexion.Connect())
            {
                string query = "SELECT nombre, rol, contraseña FROM usuarios WHERE email = @email";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new usuarioEntyti
                            {
                                Nombre = reader.GetString("nombre"),
                                Rol = reader.GetString("rol"),
                                Contraseña = reader.GetString("contraseña")
                            };
                        }
                    }
                }
            }

            return null;
        }


        public int GuardarUsuario(usuarioEntyti usuario)
        {
            int resultado = 0;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "RegistrarUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;

                    string hash = BCrypt.Net.BCrypt.HashPassword(usuario.Contraseña);

                    cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@p_email", usuario.Email);
                    cmd.Parameters.AddWithValue("@p_contraseña", hash);
                    cmd.Parameters.AddWithValue("@p_rol", usuario.Rol);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar usuario: " + ex.Message);
            }

            return resultado;
        }
    }
}
