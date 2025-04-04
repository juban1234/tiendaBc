using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Modelo;
using Modelo.Entity;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace logica
{
    public class VendedorController:vendedorBD
    {
        private vendedorBD db = new vendedorBD();
        public List<ProductoEntity> VerProductos()
        {
            List<ProductoEntity> productos = db.TraerProductos();  // Corrigiendo el nombre del método

            return productos;
        }
        public ProductoEntity buscarProducto(string nombre)
        {
            return db.BuscarProducto(nombre); // Devuelve el producto encontrado o null
        }
    }
}

