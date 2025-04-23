using Modelo.Entity;
using Modelo;
using Modelo.Entitys;

public class VendedorController
{
    private vendedorBD db = new vendedorBD();

    public List<ProductoEntity> VerProductos()
    {
        return db.TraerProductos();
    }

    public ProductoEntity BuscarProducto(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            return null;

        return db.BuscarProducto(nombre);
    }

    public int VentaProducto(string nombre , string cantidad , int usuario)
    {

        ProductoEntity producto = new ProductoEntity
        {
            Nombre = nombre,
            Cantidad = Convert.ToInt32(cantidad),
            Id = usuario  
        };



        return db.venderProducto(producto);
    }
}
