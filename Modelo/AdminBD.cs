using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entity;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class AdminBD : ConexionMsql
    {
        private ConexionMsql conexion = new();

        public int GuardarProducto(ProductoEntity producto)
        {
            int resultado = 0;
            try
            {
                // Usamos parámetros para evitar inyección SQL
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    // Llamamos al procedimiento almacenado GuardarProducto
                    cmd.CommandText = "GuardarProducto";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Definir los parámetros
                    cmd.Parameters.AddWithValue("@p_nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@p_descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@p_precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@pr_id", producto.Id_provedor);

                    // Si la imagen no es null, agregarla como parámetro
                    if (producto.Imagen != null)
                    {
                        cmd.Parameters.AddWithValue("@p_imagen", producto.Imagen);
                    }
                    else
                    {
                        // Si no se proporciona una imagen, insertar un valor NULL
                        cmd.Parameters.AddWithValue("@p_imagen", DBNull.Value);
                    }

                    // Ejecutar el comando SQL
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al guardar producto: " + ex.Message);
            }

            return resultado;
        }

        public int EliminarUsuario(ProductoEntity producto)
        {
            int eliminado = 0;

            try
            {
                using (MySqlCommand comando = GetConnection().CreateCommand())
                {
                    comando.CommandText = "EliminarProductoPorId";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@producto_name", producto.Nombre);

                    eliminado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar usuario: " + ex.Message);
            }

            return eliminado;
        }

        public int EditarProducto(ProductoEntity producto)
        {
            int editado = 0;
            try
            {
                using (MySqlCommand comando = GetConnection().CreateCommand())
                {
                    comando.CommandText = "EditarProducto";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@p_descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@p_precio", producto.Precio);
                    comando.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);
                    editado = comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Editar el producto: " + ex.Message);
            }
            return editado;
        }
    }
}
