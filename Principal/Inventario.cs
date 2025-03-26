using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace Principal
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        private void btBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btAgregarP_Click(object sender, EventArgs e)
        {
            AgregarP agregarP = new AgregarP();
            agregarP.ShowDialog();
        }

        private void btEditarP_Click(object sender, EventArgs e)
        {
            EditarUsuario editar = new EditarUsuario();
            editar.ShowDialog();
        }

        private void btEliminarP_Click(object sender, EventArgs e)
        {
            EliminarP eliminarP = new EliminarP();
            eliminarP.ShowDialog();
        }

        private void btTraerProducto_Click(object sender, EventArgs e)
        {
            UsuarioController us = new UsuarioController();
            var productos = us.TraerProductos();


            panelContainer.Controls.Clear();

            int yOffset = 10;

            foreach (var producto in productos)
            {
                Label lblProducto = new Label();
                lblProducto.Text = $"Nombre: {producto.nombre}\nDescripción: {producto.descripcion}\nStock: {producto.cantidad}";
                lblProducto.AutoSize = true;
                lblProducto.Location = new Point(10, yOffset);

                panelContainer.Controls.Add(lblProducto);

                yOffset += 50;
            }
        }

        private void btAgregarProve_Click(object sender, EventArgs e)
        {
            AgregarProve agregarProve = new AgregarProve(); 
            agregarProve.ShowDialog();
        }


    }
}
