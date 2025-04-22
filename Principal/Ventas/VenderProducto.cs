using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.Ventas;

namespace Principal.Ventas
{
    public partial class venderProducto : Form
    {
        public venderProducto()
        {
            InitializeComponent();
        }

        private VendedorController controller = new VendedorController();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.VentaProducto(
                TbNombre_P.Text,
                TbCantidad_P.Text,
                TbUsuario.Text
                );

                this.Close();
            }
            catch (FormatException)
            {
                LbResult.Text = "error al buscar este producto";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
