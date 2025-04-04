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

namespace Principal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private usuarioEntyti usuarioValitor = new usuarioEntyti();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string clave = tbContraseña.Text;

            // Consulta segura con parámetros
            string query = "SELECT contraseña, rol FROM usuarios WHERE nombre = @usuario";

            using (MySqlConnection conexion = new MySqlConnection("tu_cadena_conexion"))
            {
                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string claveAlmacenada = reader.GetString(0);
                                string rol = reader.GetString(1);

                                // Verificar la contraseña cifrada
                                if (BCrypt.Net.BCrypt.Verify(clave, claveAlmacenada))
                                {
                                    MessageBox.Show("Inicio de sesión exitoso");

                                    // Guardar el rol para futuras validaciones
                                    usuarioValitor.Rol = rol;

                                    // Abrir el menú principal
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

