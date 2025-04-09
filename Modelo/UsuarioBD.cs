using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entitys;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class UsuarioBD:ConexionMsql
    {
        private ConexionMsql conexion = new ConexionMsql();

        public usuarioEntyti BuscarUsuarioPorEmail(string email)
        {
            usuarioEntyti usuario = null;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "BuscarUsuarioPorEmail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new usuarioEntyti
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre"),
                                Email = reader.GetString("email"),
                                Contraseña = reader.GetString("contraseña"),
                                Rol = reader.GetString("rol")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }

            return usuario;
        }

        public int GuardarUsuario(usuarioEntyti usuario)
        {
            int usuarios = 0;
            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "RegistrarUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@p_email", usuario.Email);
                    cmd.Parameters.AddWithValue("@p_contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@p_rol", usuario.Rol);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error al Editar el producto: " + ex.Message);
            }

            return usuarios;
        }
    }
}
