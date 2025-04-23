using Modelo.Entitys;

namespace Principal.Ventas
{
    public partial class venderProducto : Form
    {


        public venderProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendedorController controller = new VendedorController();

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


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void btnCerrar_Click(object sender, EventArgs e)
        //{
        //}

        //private void btnMinizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}


    }
}
