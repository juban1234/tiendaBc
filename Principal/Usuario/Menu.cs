using Modelo;
using Modelo.Entitys;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace Principal
{
    public partial class Menu : Form
    {
        private usuarioEntyti usuarioActual;

        public Menu(usuarioEntyti usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            AplicarPermisosPorRol();
        }

        private void AplicarPermisosPorRol()
        {
            // Ocultar o mostrar botones seg�n el rol
            if (usuarioActual.Rol == "vendedor")
            {
                // Por ejemplo, ocultar bot�n de inventario
                inventario.Enabled = false;
            }
            else if (usuarioActual.Rol == "administrador")
            {
                // Mostrar todo si es administrador
                ventas.Enabled = false;
                inventario.Visible = true;
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }
    }
}
