using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Modelo;
using Modelo.Entity;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace logica
{
    public class UsuarioController:BaseDatos
    {
        private BaseDatos db;
        public List<ProductoEntity> VerProductos()
        {
            db = new BaseDatos();
            List<ProductoEntity> productos = db.TraerProductos();  // Corrigiendo el nombre del método

            return productos;
        }
        public string GuardarProducto(string nombre, string descripcion, string precio, string cantidad, string imagen,string id_provedor)
        {
            // Crear un objeto ProductoEntity
            ProductoEntity producto = new ProductoEntity
            {
                nombre = nombre,
                descripcion = descripcion,
                precio = Convert.ToDouble(precio),  
                cantidad = Convert.ToInt32(cantidad),  
                imagen = Convert.FromBase64String(imagen) , 
                id_provedor = Convert.ToInt32(id_provedor)
            };

            db = new BaseDatos();
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
            db = new BaseDatos();

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

            db = new BaseDatos();
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

        public ProductoEntity buscarProducto(string nombre)
        {
            db = new BaseDatos();
            return db.BuscarProducto(nombre); // Devuelve el producto encontrado o null
        }
    }
}

