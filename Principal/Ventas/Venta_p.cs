﻿using Modelo;
using Modelo.Entity;

namespace Principal.Ventas
{
    public partial class Venta_p : Form
    {
        public Venta_p()
        {
            InitializeComponent();
        }

        private void BtBusqueda_Click(object sender, EventArgs e)
        {
            vendedorBD db = new vendedorBD();
            VendedorController controller = new VendedorController();
            ProductoEntity producto = db.BuscarProducto(TbBusqueda.Text);

            if (producto != null)
            {
                lbResult.Text = $"producto Nombre: {producto.Nombre}, Precio: {producto.Precio}, cantidad: {producto.Cantidad}";
            }
            else
            {
                lbResult.Text = "No se encontró el producto.";
            }
        }

        private void BtTraerProducto_Click(object sender, EventArgs e)
        {
            obtenerInventario();
        }

        private void BtVende_P_Click(object sender, EventArgs e)
        {
            venderProducto vender = new venderProducto();
            vender.Show();
        }

        private void Venta_p_Load(object sender, EventArgs e)
        {
            obtenerInventario();
        }
    
        private void obtenerInventario()
        {
            VendedorController us = new();
            var productos = us.VerProductos();


            PanelContainer.Controls.Clear();

            int yOffset = 10;

            foreach (var producto in productos)
            {
                Label lblProducto = new();
                lblProducto.Text = $"{producto.Nombre}\n {producto.Cantidad}";
                lblProducto.AutoSize = true;
                lblProducto.Location = new Point(10, yOffset);

                PanelContainer.Controls.Add(lblProducto);

                yOffset += 50;
            }
        }
    }
}
