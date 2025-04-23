namespace Principal
{
    partial class EliminarP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarP));
            btElimninar = new Button();
            resultado = new Label();
            tbId = new TextBox();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btElimninar
            // 
            btElimninar.BackColor = Color.FromArgb(40, 40, 40);
            btElimninar.FlatAppearance.BorderSize = 0;
            btElimninar.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btElimninar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btElimninar.FlatStyle = FlatStyle.Flat;
            btElimninar.ForeColor = Color.LightGray;
            btElimninar.Location = new Point(133, 279);
            btElimninar.Margin = new Padding(3, 4, 3, 4);
            btElimninar.Name = "btElimninar";
            btElimninar.Size = new Size(417, 45);
            btElimninar.TabIndex = 0;
            btElimninar.Text = "Eliminar Producto";
            btElimninar.UseVisualStyleBackColor = false;
            btElimninar.Click += btElimninar_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(143, 267);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 20);
            resultado.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(15, 15, 15);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.ForeColor = Color.DimGray;
            tbId.Location = new Point(124, 175);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "Nombre del Producto";
            tbId.Size = new Size(426, 25);
            tbId.TabIndex = 2;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(183, 0);
            btnMinizar.Margin = new Padding(3, 4, 3, 4);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(32, 36);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 20;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(221, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 36);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 21;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 240);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinizar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(664, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(124, 216);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 2);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(124, 43);
            label1.Name = "label1";
            label1.Size = new Size(417, 40);
            label1.TabIndex = 24;
            label1.Text = "Eliminacion de Producto";
            // 
            // EliminarP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(914, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(tbId);
            Controls.Add(resultado);
            Controls.Add(btElimninar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EliminarP";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarP";
            Load += EliminarP_Load;
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btElimninar;
        private Label resultado;
        private TextBox tbId;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}