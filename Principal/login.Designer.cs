namespace Principal
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            btnIniciarSesion = new Button();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            btRegistro = new Button();
            label1 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(40, 40, 40);
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.LightGray;
            btnIniciarSesion.Location = new Point(333, 211);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(400, 40);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.BackColor = Color.FromArgb(15, 15, 15);
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.ForeColor = Color.White;
            tbUsuario.Location = new Point(333, 84);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "Usuario";
            tbUsuario.Size = new Size(416, 20);
            tbUsuario.TabIndex = 1;
            tbUsuario.Enter += tbUsuario_Enter;
            tbUsuario.Leave += tbUsuario_Leave;
            // 
            // tbContraseña
            // 
            tbContraseña.BackColor = Color.FromArgb(15, 15, 15);
            tbContraseña.BorderStyle = BorderStyle.None;
            tbContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContraseña.ForeColor = Color.White;
            tbContraseña.Location = new Point(333, 148);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "Contraseña";
            tbContraseña.Size = new Size(416, 20);
            tbContraseña.TabIndex = 2;
            tbContraseña.Enter += tbContraseña_Enter;
            tbContraseña.Leave += tbContraseña_Leave;
            // 
            // btRegistro
            // 
            btRegistro.BackColor = Color.FromArgb(40, 40, 40);
            btRegistro.FlatAppearance.BorderSize = 0;
            btRegistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btRegistro.FlatStyle = FlatStyle.Flat;
            btRegistro.ForeColor = Color.LightGray;
            btRegistro.Location = new Point(333, 267);
            btRegistro.Name = "btRegistro";
            btRegistro.Size = new Size(400, 40);
            btRegistro.TabIndex = 3;
            btRegistro.Text = "Registro";
            btRegistro.UseVisualStyleBackColor = false;
            btRegistro.Click += btRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(478, 31);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 4;
            label1.Text = "TiendaBc";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(272, 75);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(333, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 1);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(333, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(416, 1);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(755, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 10;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(721, 0);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 11;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnMinizar);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btRegistro);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(btnIniciarSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private Button btRegistro;
        private Label label1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnCerrar;
        private PictureBox btnMinizar;
    }
}