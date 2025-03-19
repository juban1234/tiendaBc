using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo.Entity;

namespace logica
{
    public class eliminarController
    {
        public int EliminarProducto(int productoId)
        {
            int filasAfectadas = 0;
            try
            {
                
                    using (MySqlCommand cmd = CreateCommand())
                    {
                        cmd.CommandText = "EliminarProductoPorId"; // Nombre del SP
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@producto_id", productoId);

                        filasAfectadas = cmd.ExecuteNonQuery(); // Devuelve el número de filas afectadas
                    }
          
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar producto: " + ex.Message);
                filasAfectadas = -1; // Indicar que ocurrió un error
            }

            return filasAfectadas;
        }


    }
}
