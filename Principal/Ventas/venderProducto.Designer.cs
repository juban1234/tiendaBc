namespace Principal.Ventas
{
    partial class venderProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venderProducto));
            button1 = new Button();
            TbNombre_P = new TextBox();
            TbCantidad_P = new TextBox();
            LbResult = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            btnMinizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(379, 254);
            button1.Name = "button1";
            button1.Size = new Size(272, 40);
            button1.TabIndex = 0;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = false;
            // 
            // TbNombre_P
            // 
            TbNombre_P.BackColor = Color.FromArgb(15, 15, 15);
            TbNombre_P.BorderStyle = BorderStyle.None;
            TbNombre_P.Font = new Font("Microsoft Sans Serif", 12F);
            TbNombre_P.ForeColor = Color.DimGray;
            TbNombre_P.Location = new Point(312, 81);
            TbNombre_P.Name = "TbNombre_P";
            TbNombre_P.PlaceholderText = "nombre producto";
            TbNombre_P.Size = new Size(416, 19);
            TbNombre_P.TabIndex = 1;
            // 
            // TbCantidad_P
            // 
            TbCantidad_P.BackColor = Color.FromArgb(15, 15, 15);
            TbCantidad_P.BorderStyle = BorderStyle.None;
            TbCantidad_P.Font = new Font("Microsoft Sans Serif", 12F);
            TbCantidad_P.ForeColor = Color.DimGray;
            TbCantidad_P.Location = new Point(312, 136);
            TbCantidad_P.Name = "TbCantidad_P";
            TbCantidad_P.PlaceholderText = "cantidad producto";
            TbCantidad_P.Size = new Size(416, 19);
            TbCantidad_P.TabIndex = 2;
            // 
            // LbResult
            // 
            LbResult.AutoSize = true;
            LbResult.ForeColor = Color.LightGray;
            LbResult.Location = new Point(460, 200);
            LbResult.Name = "LbResult";
            LbResult.Size = new Size(0, 15);
            LbResult.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(312, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 1);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(312, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(416, 1);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DimGray;
            pictureBox3.Enabled = false;
            pictureBox3.Location = new Point(312, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(416, 1);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 2;
            label1.Text = "Venta de Producto";
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(757, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(723, 0);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 0;
            btnMinizar.TabStop = false;
            btnMinizar.Click += this.btnMinizar_Click;
            // 
            // venderProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnMinizar);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LbResult);
            Controls.Add(TbCantidad_P);
            Controls.Add(TbNombre_P);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "venderProducto";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "venderProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TbNombre_P;
        private TextBox TbCantidad_P;
        private Label LbResult;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCerrar;
        private PictureBox btnMinizar;
    }
}
