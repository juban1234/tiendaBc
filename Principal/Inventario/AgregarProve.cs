using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Inventario
{
    public partial class AgregarProve : Form
    {
        public AgregarProve()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AgregarProve));
            button1 = new Button();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((ISupportInitialize)btnMinizar).BeginInit();
            ((ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 279);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(511, 1);
            btnMinizar.Margin = new Padding(3, 4, 3, 4);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(32, 36);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 12;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(549, 1);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 36);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 13;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // AgregarProve
            // 
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(577, 451);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinizar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarProve";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)btnMinizar).EndInit();
            ((ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
        private Button button1;

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
