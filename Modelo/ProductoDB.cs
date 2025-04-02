using Modelo.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class ProductoDB
{
    private BaseDatos db = new BaseDatos();

    public ProductoEntity BuscarProducto(string nombre)
    {
        using (MySqlConnection conexion = db.ObtenerConexion())
        {
            if (conexion == null) return null;

            string query = "CALL buscarProducto(@nombre)";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new ProductoEntity
                    {
                        nombre = reader.GetString("nombre"),
                        precio = reader.GetDouble("precio"),
                        cantidad = reader.GetInt32("cantidad"),
                    };
                }
            }
        }
        return null;
    }

    public List<ProductoEntity> traerProductos()
    {

        using (MySqlConnection conexion = db.ObtenerConexion())
        {
            if (conexion == null) return null;

            string query = "select * from";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new ProductoEntity
                    {
                        nombre = reader.GetString("nombre"),
                        precio = reader.GetDouble("precio"),
                        cantidad = reader.GetInt32("cantidad"),
                    };
                }
            }
        }
        return null;
    }

    public bool InsertarProducto(ProductoEntity producto)
    {
        using (MySqlConnection conexion = db.ObtenerConexion())
        {
            if (conexion == null) return false;

            string query = "CALL InsertarProducto(@nombre, @descripcion, @precio, @cantidad, 'Disponible',@imagen,@id_provedor)";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.precio);
            cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
            cmd.Parameters.AddWithValue("@imagen", producto.imagen);
            cmd.Parameters.AddWithValue("@id_provedor", producto.proveedor);



            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
