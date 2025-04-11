using Modelo.Entity;
using Modelo;

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
}
