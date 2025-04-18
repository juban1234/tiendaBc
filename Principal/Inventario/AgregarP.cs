﻿using System;
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
    public partial class AgregarP : Form
    {
        public AgregarP()
        {
            InitializeComponent();
        }

        private AdminController controller = new AdminController();

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbDescripcion.Text) ||
                string.IsNullOrEmpty(tbPrecio.Text) || string.IsNullOrEmpty(tbCantidad.Text) || 
                string.IsNullOrEmpty(tbProovedor.Text))
            {
                tbResultado.Text = "Por favor complete todos los campos.";
                tbResultado.ForeColor = Color.Red;
                return;
            }

            string resultado = controller.GuardarProducto(
                tbNombre.Text,
                tbDescripcion.Text,
                tbPrecio.Text,
                tbCantidad.Text,
                tbImagen.Text,
                tbProovedor.Text
            );


            tbResultado.Text = resultado;

            if (resultado == "Producto guardado con éxito.")
            {
                tbResultado.ForeColor = Color.Green;
            }
            else
            {
                tbResultado.ForeColor = Color.Red;
            }

            this.Close();
        }

    }
}
