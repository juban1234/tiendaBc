
using System.Data;
using Modelo.Entity;
using Modelo.Entitys;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class vendedorBD : ConexionMsql
    {
        ConexionMsql conexion = new ConexionMsql();
        public List<ProductoEntity> TraerProductos()
        {
            List<ProductoEntity> productos = new List<ProductoEntity>();

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "ObtenerProductos";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoEntity productoActual = new ProductoEntity();
                            productoActual.Id = dr.GetInt32(0); // id del producto
                            productoActual.Nombre = dr.GetString(1); // nombre del producto
                            productoActual.Descripcion = dr.GetString(2); // descripción
                            productoActual.Precio = dr.GetDouble(3); // precio
                            productoActual.Cantidad = dr.GetInt32(4); // cantidad

                            if (!dr.IsDBNull(5))
                            {
                                productoActual.Imagen = (byte[])dr.GetValue(5); // imagen
                            }

                            productos.Add(productoActual);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error adecuadamente (ejemplo, loguear el error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            return productos;

        }
        public ProductoEntity BuscarProducto(string nombre)
        {
            ProductoEntity producto = null;

            using (MySqlCommand conexion = GetConnection().CreateCommand())
            {
                try
                {

                    conexion.CommandText = "BuscarProductos";
                    conexion.CommandType = CommandType.StoredProcedure;
                    conexion.Parameters.AddWithValue("@p_nombre", nombre);

                    using (MySqlDataReader reader = conexion.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new ProductoEntity
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre"),
                                Precio = reader.GetDouble("precio"),
                                Cantidad = reader.GetInt32("cantidad"),
                                Descripcion = reader.GetString("descripcion")
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return producto;
        }

        public int venderProducto(ProductoEntity producto)
        {
            int vender = 0;

            try
            {
                using (MySqlCommand comando = GetConnection().CreateCommand())
                {
                    comando.CommandText = "VenderProducto";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_nombre_producto", producto.Nombre);
                    comando.Parameters.AddWithValue("@p_cantidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@p_id_usuario", producto.Id);
                    vender = comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Vender el producto: " + ex.Message);
            }

            return vender;
        }
    }
}

