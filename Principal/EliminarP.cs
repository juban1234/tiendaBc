using System;
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

        private void btElimninar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbId.Text) || !int.TryParse(tbId.Text, out int idProducto))
            {
                resultado.Text = "Ingrese un ID válido.";
                resultado.ForeColor = Color.Red;
                return;
            }

            UsuarioController controller = new UsuarioController();


            string eliminado = controller.EliminarUsuario(tbId.Text);

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
