namespace Principal
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            inventario = new Button();
            ventas = new Button();
            label1 = new Label();
            lbUsuario = new Label();
            btLogin = new Button();
            panel1 = new Panel();
            label2 = new Label();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // inventario
            // 
            inventario.BackColor = Color.FromArgb(40, 40, 40);
            inventario.FlatAppearance.BorderSize = 0;
            inventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            inventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            inventario.FlatStyle = FlatStyle.Flat;
            inventario.ForeColor = Color.LightGray;
            inventario.Location = new Point(91, 137);
            inventario.Name = "inventario";
            inventario.Size = new Size(318, 40);
            inventario.TabIndex = 1;
            inventario.Text = "inventario";
            inventario.UseVisualStyleBackColor = false;
            inventario.Click += inventario_Click;
            // 
            // ventas
            // 
            ventas.BackColor = Color.FromArgb(40, 40, 40);
            ventas.FlatAppearance.BorderSize = 0;
            ventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            ventas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            ventas.FlatStyle = FlatStyle.Flat;
            ventas.ForeColor = Color.LightGray;
            ventas.Location = new Point(91, 211);
            ventas.Name = "ventas";
            ventas.Size = new Size(318, 40);
            ventas.TabIndex = 2;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = false;
            ventas.Click += ventas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 4;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(115, 87);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(0, 15);
            lbUsuario.TabIndex = 5;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.FromArgb(40, 40, 40);
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.ForeColor = Color.LightGray;
            btLogin.Location = new Point(12, 23);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(111, 23);
            btLogin.TabIndex = 6;
            btLogin.Text = "Cerrar Sesion";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinizar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(499, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 321);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(187, 21);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 13;
            label2.Text = "TiendaBc";
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(192, 0);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 20;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(226, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 21;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(750, 321);
            Controls.Add(btLogin);
            Controls.Add(ventas);
            Controls.Add(inventario);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lbUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button inventario;
        private Button ventas;
        private Label label1;
        private Label lbUsuario;
        private Button btLogin;
        private Panel panel1;
        private Label label2;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
    }
}
