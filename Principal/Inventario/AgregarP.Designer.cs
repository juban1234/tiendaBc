namespace Principal
{
    partial class AgregarP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarP));
            btAgregar = new Button();
            tbResultado = new Label();
            tbNombre = new TextBox();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            tbImagen = new TextBox();
            tbProovedor = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.FromArgb(40, 40, 40);
            btAgregar.FlatAppearance.BorderSize = 0;
            btAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btAgregar.FlatStyle = FlatStyle.Flat;
            btAgregar.ForeColor = Color.LightGray;
            btAgregar.Location = new Point(335, 442);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(414, 33);
            btAgregar.TabIndex = 6;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // tbResultado
            // 
            tbResultado.AutoSize = true;
            tbResultado.Location = new Point(504, 180);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(0, 15);
            tbResultado.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(15, 15, 15);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Font = new Font("Microsoft Sans Serif", 12F);
            tbNombre.ForeColor = SystemColors.Menu;
            tbNombre.Location = new Point(333, 112);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(416, 19);
            tbNombre.TabIndex = 42;
            // 
            // tbCantidad
            // 
            tbCantidad.BackColor = Color.FromArgb(15, 15, 15);
            tbCantidad.BorderStyle = BorderStyle.None;
            tbCantidad.Font = new Font("Microsoft Sans Serif", 12F);
            tbCantidad.ForeColor = SystemColors.Menu;
            tbCantidad.Location = new Point(333, 259);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.PlaceholderText = "Cantidad";
            tbCantidad.Size = new Size(416, 19);
            tbCantidad.TabIndex = 41;
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.FromArgb(15, 15, 15);
            tbPrecio.BorderStyle = BorderStyle.None;
            tbPrecio.Font = new Font("Microsoft Sans Serif", 12F);
            tbPrecio.ForeColor = SystemColors.Menu;
            tbPrecio.Location = new Point(333, 206);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "Precio";
            tbPrecio.Size = new Size(416, 19);
            tbPrecio.TabIndex = 40;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(15, 15, 15);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            tbDescripcion.ForeColor = SystemColors.Menu;
            tbDescripcion.Location = new Point(333, 164);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "Descripcion";
            tbDescripcion.Size = new Size(416, 19);
            tbDescripcion.TabIndex = 39;
            // 
            // tbImagen
            // 
            tbImagen.BackColor = Color.FromArgb(15, 15, 15);
            tbImagen.BorderStyle = BorderStyle.None;
            tbImagen.Font = new Font("Microsoft Sans Serif", 12F);
            tbImagen.ForeColor = SystemColors.Menu;
            tbImagen.Location = new Point(333, 314);
            tbImagen.Name = "tbImagen";
            tbImagen.PlaceholderText = "Imagen";
            tbImagen.Size = new Size(417, 19);
            tbImagen.TabIndex = 4;
            // 
            // tbProovedor
            // 
            tbProovedor.BackColor = Color.FromArgb(15, 15, 15);
            tbProovedor.BorderStyle = BorderStyle.None;
            tbProovedor.Font = new Font("Microsoft Sans Serif", 12F);
            tbProovedor.ForeColor = SystemColors.Menu;
            tbProovedor.Location = new Point(333, 366);
            tbProovedor.Name = "tbProovedor";
            tbProovedor.PlaceholderText = "Proveedor";
            tbProovedor.Size = new Size(417, 19);
            tbProovedor.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(397, 38);
            label2.Name = "label2";
            label2.Size = new Size(242, 31);
            label2.TabIndex = 44;
            label2.Text = "Agregar Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 525);
            panel1.TabIndex = 45;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(741, 0);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 46;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(774, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 47;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(333, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 1);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(333, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(416, 1);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DimGray;
            pictureBox3.Enabled = false;
            pictureBox3.Location = new Point(335, 391);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(416, 1);
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DimGray;
            pictureBox4.Enabled = false;
            pictureBox4.Location = new Point(335, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(416, 1);
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Enabled = false;
            pictureBox5.Location = new Point(333, 284);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(416, 1);
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DimGray;
            pictureBox6.Enabled = false;
            pictureBox6.Location = new Point(333, 189);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(416, 1);
            pictureBox6.TabIndex = 53;
            pictureBox6.TabStop = false;
            // 
            // AgregarP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(796, 525);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinizar);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(tbProovedor);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(tbResultado);
            Controls.Add(btAgregar);
            Controls.Add(tbImagen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarP";
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAgregar;
        private Label tbResultado;
        private TextBox tbNombre;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
        private TextBox tbImagen;
        private TextBox tbProovedor;
        private Label label2;
        private Panel panel1;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}