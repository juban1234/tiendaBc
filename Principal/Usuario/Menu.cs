using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace Principal
{
    public partial class Menu : Form
    {
        private string nombreUsuario;
        private string rolUsuario;

        public Menu(string nombre, string rol)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }

        private void AplicarPermisosPorRol()
        {
            // Ocultar o mostrar botones según el rol
            switch (rolUsuario)
            {
                case "administrador":
                    // Tiene acceso a todo
                    break;

                case "vendedor":
                    inventario.Visible = false; // No puede ver inventario
                    break;

                case "jefe":
                    ventas.Visible = false; // No puede ver ventas
                    break;

                default:
                    MessageBox.Show("Rol no reconocido. Cerrando aplicación.");
                    this.Close();
                    break;
            }
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            InventarioP inventario = new InventarioP();
            inventario.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }
    }
}
