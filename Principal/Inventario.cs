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

        private void btTraerProducto_Click(object sender, EventArgs e)
        {
            UsuarioController us = new UsuarioController();
            var productos = us.TraerProductos();

            string resultado = "";
            foreach (var producto in productos)
            {
                resultado += "nombre: " + producto.nombre + "\n" + " descripciones: " + producto.descripcion + "\n" + " stock: " + producto.cantidad + "\n\n";
            }

            lbResult.Text = resultado;


        }

        private void btEditarP_Click(object sender, EventArgs e)
        {
            EditarUsuario editar = new EditarUsuario();
            editar.ShowDialog();
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
