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
        
        public venderProducto()
        {
            InitializeComponent();
            
        }

        private VendedorController controller = new VendedorController();

        private void button1_Click(object sender, EventArgs e)
        {
            int usuario = SesionActual.ObtenerUsuario().Id_usuario;

            try
            {
                controller.VentaProducto(
                TbNombre_P.Text,
                TbCantidad_P.Text,
                usuario
                );

                if (controller != null)
                {
                    LbResult.Text = "producto vendido";
                }

                     
                
            }
            catch (FormatException)
            {
                LbResult.Text = "error al buscar este producto";
            }
        }
    }
}
