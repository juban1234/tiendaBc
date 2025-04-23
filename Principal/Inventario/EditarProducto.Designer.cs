namespace Principal
{
    partial class EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            btEditarP = new Button();
            tbNombre = new TextBox();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            Resultado1 = new Label();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btEditarP
            // 
            btEditarP.BackColor = Color.FromArgb(40, 40, 40);
            btEditarP.FlatAppearance.BorderSize = 0;
            btEditarP.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btEditarP.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btEditarP.FlatStyle = FlatStyle.Flat;
            btEditarP.ForeColor = Color.LightGray;
            btEditarP.Location = new Point(481, 401);
            btEditarP.Margin = new Padding(3, 4, 3, 4);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(239, 50);
            btEditarP.TabIndex = 40;
            btEditarP.Text = "Editar productos";
            btEditarP.UseVisualStyleBackColor = false;
            btEditarP.Click += btEditarP_Click;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(15, 15, 15);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.ForeColor = Color.White;
            tbNombre.Location = new Point(361, 114);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(475, 25);
            tbNombre.TabIndex = 38;
            // 
            // tbCantidad
            // 
            tbCantidad.BackColor = Color.FromArgb(15, 15, 15);
            tbCantidad.BorderStyle = BorderStyle.None;
            tbCantidad.Font = new Font("Century Gothic", 12F);
            tbCantidad.ForeColor = Color.White;
            tbCantidad.Location = new Point(361, 326);
            tbCantidad.Margin = new Padding(3, 4, 3, 4);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.PlaceholderText = "Cantidad";
            tbCantidad.Size = new Size(475, 25);
            tbCantidad.TabIndex = 33;
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.FromArgb(15, 15, 15);
            tbPrecio.BorderStyle = BorderStyle.None;
            tbPrecio.Font = new Font("Century Gothic", 12F);
            tbPrecio.ForeColor = Color.White;
            tbPrecio.Location = new Point(361, 251);
            tbPrecio.Margin = new Padding(3, 4, 3, 4);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "Precio";
            tbPrecio.Size = new Size(475, 25);
            tbPrecio.TabIndex = 32;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(15, 15, 15);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Font = new Font("Century Gothic", 12F);
            tbDescripcion.ForeColor = Color.White;
            tbDescripcion.Location = new Point(361, 182);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "Descripcion";
            tbDescripcion.Size = new Size(475, 25);
            tbDescripcion.TabIndex = 31;
            // 
            // Resultado1
            // 
            Resultado1.AutoSize = true;
            Resultado1.Location = new Point(433, 145);
            Resultado1.Name = "Resultado1";
            Resultado1.Size = new Size(0, 20);
            Resultado1.TabIndex = 41;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(821, 0);
            btnMinizar.Margin = new Padding(3, 4, 3, 4);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(32, 36);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 42;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(859, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 36);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 43;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(431, 29);
            label2.Name = "label2";
            label2.Size = new Size(266, 40);
            label2.TabIndex = 44;
            label2.Text = "Editar Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 476);
            panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(361, 149);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 1);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(361, 217);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(475, 1);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DimGray;
            pictureBox3.Enabled = false;
            pictureBox3.Location = new Point(361, 361);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(475, 1);
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DimGray;
            pictureBox4.Enabled = false;
            pictureBox4.Location = new Point(361, 286);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(475, 1);
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(890, 476);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinizar);
            Controls.Add(Resultado1);
            Controls.Add(btEditarP);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarUsuario";
            Load += EditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditarP;
        private Label label1;
        private TextBox tbNombre;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
        private Label Resultado1;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}