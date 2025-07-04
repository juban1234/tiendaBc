using Modelo;
using Modelo.Entitys;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Principal.Ventas;

namespace Principal
{
    public partial class Menu : Form
    {
        private usuarioEntyti usuarioA;

        public Menu(usuarioEntyti usuario)
        {
            InitializeComponent();
            usuarioA = usuario;
            AplicarPermisosPorRol();
        }

        private void AplicarPermisosPorRol()
        {
            // Ocultar o mostrar botones seg�n el rol
            if (usuarioA.Rol == "vendedor")
            {
                // Por ejemplo, ocultar bot�n de inventario
                inventario.Enabled = false;
            }
            else if (usuarioA.Rol == "administrador")
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
            Venta_p ventas = new Venta_p();
            ventas.Show();

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (SesionActual.EstaAutenticado())
            {
                LbBienvenido.Text = "Bienvenido " + SesionActual.ObtenerUsuario().Nombre; 
            }
            else
            {
                LbBienvenido.Text = "Bienvenido invitado";
            }
        }
    }
}
