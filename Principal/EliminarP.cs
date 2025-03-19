using System;
using System.Drawing;
using System.Windows.Forms;
using logica;

namespace Principal
{
    public partial class EliminarP : Form
    {
        private UsuarioController controller; // Instancia del controlador

        public EliminarP()
        {
            InitializeComponent();
            controller = new UsuarioController(); // Inicializar el controlador
        }

        private void btElimninar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNombreP.Text) || !int.TryParse(tbNombreP.Text, out int idProducto))
            {
                resultado.Text = "Ingrese un ID válido.";
                resultado.ForeColor = Color.Red;
                return;
            }

 
            int eliminado = controller.EliminarUsuario(idProducto);

            // Mostrar el resultado en tbResultado
            if (eliminado > 0)
            {
                resultado.Text = "Producto eliminado con éxito.";
                resultado.ForeColor = Color.Green;
            }
            else
            {
                resultado.Text = "No se encontró el producto o no pudo ser eliminado.";
                resultado.ForeColor = Color.Red;
            }
        }
    }
}
