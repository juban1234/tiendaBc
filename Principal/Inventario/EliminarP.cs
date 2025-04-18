﻿using System;
using System.Drawing;
using System.Windows.Forms;
using logica;

namespace Principal
{
    public partial class EliminarP : Form
    {
        

        public EliminarP()
        {
            InitializeComponent();
            
        }

        private AdminController controller = new AdminController();

        private void btElimninar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbId.Text))
            {
                resultado.Text = "Ingrese un nombre que exist< en el inventario válido.";
                resultado.ForeColor = Color.Red;
                return;
            }

            


            string eliminado = controller.EliminarProducto(tbId.Text);

            resultado.Text = eliminado;


            if (eliminado == "Producto Eliminado con éxito.")
            {
                resultado.ForeColor = Color.Green;
            }
            else
            {
                resultado.ForeColor = Color.Red;
            }
        }
    }
}
