using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace Principal.Usuario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();

            try
            {
                string nombre = TbNombre.Text;
                string email = TbEmail.Text;
                string contraseña = TbPassword.Text;
                string rol = TbRol.Text; // ComboBox de roles

                string resultado = controller.RegistrarUsuario(nombre, email, contraseña, rol);

                this.Hide();
                login login = new login();
                login.FormClosed += (s, args) => Application.Exit();
                login.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Editar el producto: " + ex.Message);
            }
        }

        private void TbNombre_Enter(object sender, EventArgs e)
        {
            if (TbNombre.Text == "Nombre")
            {
                TbNombre.Text = "";
                TbNombre.ForeColor = Color.LightGray;
            }
        }

        private void TbNombre_Leave(object sender, EventArgs e)
        {
            if (TbNombre.Text == "")
            {
                TbNombre.Text = "Nombre";
                TbNombre.ForeColor = Color.DimGray;
            }
        }

        private void TbEmail_Enter(object sender, EventArgs e)
        {
            if (TbEmail.Text == "Email")
            {
                TbEmail.Text = "";
                TbEmail.ForeColor = Color.LightGray;
            }
        }

        private void TbEmail_Leave(object sender, EventArgs e)
        {
            if (TbEmail.Text == "")
            {
                TbEmail.Text = "Email";
                TbEmail.ForeColor = Color.DimGray;
            }
        }

        private void TbPassword_Enter(object sender, EventArgs e)
        {
            if (TbPassword.Text == "Contraseña")
            {
                TbPassword.Text = "";
                TbPassword.ForeColor = Color.DimGray;
                TbPassword.UseSystemPasswordChar = true;
            }
        }

        private void TbPassword_Leave(object sender, EventArgs e)
        {
            if (TbPassword.Text == "")
            {
                TbPassword.Text = "Contraseña";
                TbPassword.ForeColor = Color.DimGray;
                TbPassword.UseSystemPasswordChar = false;
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
