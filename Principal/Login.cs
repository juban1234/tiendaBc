using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using Modelo.Entitys;
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu1 = new Menu();
            menu1.FormClosed += (s, args) => Application.Exit();
            menu1.Show();
           
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
    }
}

