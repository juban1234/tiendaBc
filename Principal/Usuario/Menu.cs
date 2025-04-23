using Modelo.Entitys;
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
            // Ocultar o mostrar botones según el rol
            if (usuarioA.Rol == "vendedor")
            {
                inventario.Enabled = false;
            }
            else if (usuarioA.Rol == "administrador")
            {
                ventas.Enabled = false;
                inventario.Visible = true;
            }
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            InventarioP inventario = new InventarioP();
            inventario.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Venta_p ventas = new Venta_p();
            ventas.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            this.Close();
            login login = new login();
            login.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load_1(object sender, EventArgs e)
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
