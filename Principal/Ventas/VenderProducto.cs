using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entitys;
using Principal.Ventas;

namespace Principal.Ventas
{
    public partial class venderProducto : Form
    {
        private VendedorController controller = new VendedorController();

        public venderProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int usuario = SesionActual.ObtenerUsuario().Id_usuario;

                controller.VentaProducto(
                    TbNombre_P.Text,
                    TbCantidad_P.Text,
                    usuario
                );

                LbResult.Text = "producto vendido";
                this.Close();
            }
            catch (FormatException)
            {
                LbResult.Text = "error al buscar este producto";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerramos solo la ventana actual, no toda la aplicación
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
