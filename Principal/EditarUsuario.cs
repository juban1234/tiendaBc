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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btEditarP_Click(object sender, EventArgs e)
        {

            UsuarioController controller = new UsuarioController();

            string resultado = controller.EditarProducto(
                tbNombre.Text,
                tbDescripcion.Text,
                tbPrecio.Text,
                tbCantidad.Text
            );

            Resultado1.Text = resultado;

            if (resultado == "Producto guardado con éxito.")
            {
                Resultado1.ForeColor = Color.Green;
            }
            else
            {
                Resultado1.ForeColor = Color.Red;
            }
        }

    }
}
