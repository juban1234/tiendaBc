using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entity;

namespace logica
{
    public class adminController:BaseDatos
    {
        private BaseDatos db = new BaseDatos();
        public string GuardarProducto(string nombre, string descripcion, string precio, string cantidad, string imagen, string id_provedor)
        {
            // Crear un objeto ProductoEntity
            ProductoEntity producto = new ProductoEntity
            {
                nombre = nombre,
                descripcion = descripcion,
                precio = Convert.ToDouble(precio),
                cantidad = Convert.ToInt32(cantidad),
                imagen = Convert.FromBase64String(imagen),
                id_provedor = Convert.ToInt32(id_provedor)
            };

            
            int resultado = db.GuardarProducto(producto);

            if (resultado > 0)
            {
                return "Producto guardado con éxito.";
            }
            else
            {
                return "Error al guardar el producto.";
            }
        }
        public string EliminarUsuario(string name)
        {
            ProductoEntity producto = new ProductoEntity { nombre = name };

            int resultado = db.EliminarUsuario(producto);
            if (resultado > 0)
            {
                return "Producto Eliminado con éxito.";
            }
            else
            {
                return "Error al Eliminado el producto.";
            }
        }
        public string EditarProducto(string nombre, string descripcion, string precio, string cantidad)
        {
            ProductoEntity producto = new ProductoEntity
            {
                nombre = nombre,
                descripcion = descripcion,
                precio = Convert.ToDouble(precio),
                cantidad = Convert.ToInt32(cantidad),
            };

            int resultado = db.EditarProducto(producto);

            if (resultado > 0)
            {
                return "Producto editado con éxito.";
            }
            else
            {
                return "Error al editado el producto.";
            }
        }

    }
}
