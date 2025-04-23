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
        private ConexionMsql db = new ConexionMsql();

        // usuarioBD.cs
        public usuarioEntyti BuscarUsuarioPorEmail(string email)
        {
            usuarioEntyti usuario = null;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "BuscarUsuarioPorEmail"; 
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro del procedimiento
                    cmd.Parameters.AddWithValue("@p_email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new usuarioEntyti
                            {
                                Id_usuario = reader.GetInt16("id"),
                                Nombre = reader.GetString("nombre"),
                                Rol = reader.GetString("rol"),
                                Contraseña = reader.GetString("contraseña")
                            };
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }

            return usuario;
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
                    cmd.Parameters.AddWithValue("@p_contraseña", usuario.Contraseña);
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
