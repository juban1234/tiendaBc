using Modelo;
using Modelo.Entity;


namespace logica
{
    public class productoController:BaseDatos
    {
        ProductoDB producto = new ProductoDB();

        public List<productoController> traerProductos()
        {

            return new List<productoController>();
        }

        public ProductoEntity buscarProducto(string nombre)
        {
            
            return producto.BuscarProducto(nombre); 
        }

        public bool AgregarProducto(string nombre, string descripcion, double precio, int cantidad,int proveedor)
        {
            ProductoEntity nuevoProducto = new ProductoEntity
            {
                nombre = nombre,
                descripcion = descripcion,
                precio = precio,
                cantidad = cantidad,
                proveedor = proveedor,
            };

            return producto.InsertarProducto(nuevoProducto);
        }
        

    }
}

