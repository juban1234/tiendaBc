
using logica;
using Principal.Usuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Principal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private UsuarioController auth = new UsuarioController();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            string resultado = auth.Login(email, contraseña);

            MessageBox.Show(resultado);

            if (resultado.StartsWith("Bienvenido"))
            {
                
                Menu menu1 = new Menu();
                menu1.FormClosed += (s, args) => Application.Exit();
                menu1.Show();
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

