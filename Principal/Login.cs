using logica;
using Principal.Usuario;
using System;
using System.Windows.Forms;


namespace Principal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private UsuarioController controlador = new UsuarioController();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = tbUsuario.Text.Trim();
            string contraseña = tbContraseña.Text;

            var usuario = controlador.Login(correo, contraseña);

            if (usuario != null)
            {
                
                Menu menu = new Menu(usuario.Nombre, usuario.Rol);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();

        }
    }
}

