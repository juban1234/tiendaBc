namespace Principal
{
    partial class InventarioP
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioP));
            BtTraerProducto = new Button();
            BtEditarP = new Button();
            TbBusqueda = new TextBox();
            BtBusqueda = new Button();
            BtAgregarProve = new Button();
            BtEliminarP = new Button();
            BtAgregarP = new Button();
            lbResult = new Label();
            PanelContainer = new Panel();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BtTraerProducto
            // 
            BtTraerProducto.BackColor = Color.FromArgb(40, 40, 40);
            BtTraerProducto.FlatAppearance.BorderSize = 0;
            BtTraerProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtTraerProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtTraerProducto.FlatStyle = FlatStyle.Flat;
            BtTraerProducto.ForeColor = Color.LightGray;
            BtTraerProducto.Location = new Point(39, 300);
            BtTraerProducto.Name = "BtTraerProducto";
            BtTraerProducto.Size = new Size(131, 38);
            BtTraerProducto.TabIndex = 0;
            BtTraerProducto.Text = "Inventario de  Productos ";
            BtTraerProducto.UseVisualStyleBackColor = false;
            BtTraerProducto.Click += BtTraerProducto_Click;
            // 
            // BtEditarP
            // 
            BtEditarP.BackColor = Color.FromArgb(40, 40, 40);
            BtEditarP.FlatAppearance.BorderSize = 0;
            BtEditarP.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtEditarP.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtEditarP.FlatStyle = FlatStyle.Flat;
            BtEditarP.ForeColor = Color.LightGray;
            BtEditarP.Location = new Point(39, 194);
            BtEditarP.Name = "BtEditarP";
            BtEditarP.Size = new Size(131, 32);
            BtEditarP.TabIndex = 2;
            BtEditarP.Text = "Editar Producto";
            BtEditarP.UseVisualStyleBackColor = false;
            BtEditarP.Click += BtEditarP_Click;
            // 
            // TbBusqueda
            // 
            TbBusqueda.BackColor = Color.FromArgb(15, 15, 15);
            TbBusqueda.BorderStyle = BorderStyle.None;
            TbBusqueda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbBusqueda.ForeColor = Color.DimGray;
            TbBusqueda.Location = new Point(39, 40);
            TbBusqueda.Name = "TbBusqueda";
            TbBusqueda.PlaceholderText = "Busqueda de Productos";
            TbBusqueda.Size = new Size(383, 20);
            TbBusqueda.TabIndex = 4;
            // 
            // BtBusqueda
            // 
            BtBusqueda.BackColor = Color.FromArgb(40, 40, 40);
            BtBusqueda.FlatAppearance.BorderSize = 0;
            BtBusqueda.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtBusqueda.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtBusqueda.FlatStyle = FlatStyle.Flat;
            BtBusqueda.ForeColor = Color.LightGray;
            BtBusqueda.Location = new Point(456, 32);
            BtBusqueda.Name = "BtBusqueda";
            BtBusqueda.Size = new Size(102, 36);
            BtBusqueda.TabIndex = 5;
            BtBusqueda.Text = "busqueda";
            BtBusqueda.UseVisualStyleBackColor = false;
            BtBusqueda.Click += BtBusqueda_Click;
            // 
            // BtAgregarProve
            // 
            BtAgregarProve.BackColor = Color.FromArgb(40, 40, 40);
            BtAgregarProve.FlatAppearance.BorderSize = 0;
            BtAgregarProve.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtAgregarProve.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtAgregarProve.FlatStyle = FlatStyle.Flat;
            BtAgregarProve.ForeColor = Color.LightGray;
            BtAgregarProve.Location = new Point(39, 359);
            BtAgregarProve.Name = "BtAgregarProve";
            BtAgregarProve.Size = new Size(131, 35);
            BtAgregarProve.TabIndex = 7;
            BtAgregarProve.Text = "Agregar Proveedores";
            BtAgregarProve.UseVisualStyleBackColor = false;
            BtAgregarProve.Click += BtAgregarProve_Click;
            // 
            // BtEliminarP
            // 
            BtEliminarP.BackColor = Color.FromArgb(40, 40, 40);
            BtEliminarP.FlatAppearance.BorderSize = 0;
            BtEliminarP.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtEliminarP.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtEliminarP.FlatStyle = FlatStyle.Flat;
            BtEliminarP.ForeColor = Color.LightGray;
            BtEliminarP.Location = new Point(39, 248);
            BtEliminarP.Name = "BtEliminarP";
            BtEliminarP.Size = new Size(131, 32);
            BtEliminarP.TabIndex = 8;
            BtEliminarP.Text = "ElimiarProductos";
            BtEliminarP.UseVisualStyleBackColor = false;
            BtEliminarP.Click += BtEliminarP_Click;
            // 
            // BtAgregarP
            // 
            BtAgregarP.BackColor = Color.FromArgb(40, 40, 40);
            BtAgregarP.FlatAppearance.BorderSize = 0;
            BtAgregarP.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtAgregarP.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtAgregarP.FlatStyle = FlatStyle.Flat;
            BtAgregarP.ForeColor = Color.LightGray;
            BtAgregarP.Location = new Point(39, 137);
            BtAgregarP.Name = "BtAgregarP";
            BtAgregarP.Size = new Size(131, 32);
            BtAgregarP.TabIndex = 9;
            BtAgregarP.Text = "Agregar Productos";
            BtAgregarP.UseVisualStyleBackColor = false;
            BtAgregarP.Click += BtAgregarP_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(39, 84);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 15);
            lbResult.TabIndex = 1;
            // 
            // PanelContainer
            // 
            PanelContainer.AutoScroll = true;
            PanelContainer.BackColor = Color.LightGray;
            PanelContainer.Location = new Point(221, 137);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(499, 279);
            PanelContainer.TabIndex = 6;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(739, 1);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 19;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(773, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 20;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // InventarioP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinizar);
            Controls.Add(BtAgregarP);
            Controls.Add(BtEliminarP);
            Controls.Add(BtAgregarProve);
            Controls.Add(BtBusqueda);
            Controls.Add(TbBusqueda);
            Controls.Add(BtEditarP);
            Controls.Add(lbResult);
            Controls.Add(BtTraerProducto);
            Controls.Add(PanelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventarioP";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtTraerProducto;
        private Button BtEditarP;
        private TextBox TbBusqueda;
        private Button BtBusqueda;
        private Button BtAgregarProve;
        private Button BtEliminarP;
        private Button BtAgregarP;
        private Label lbResult;
        private Panel PanelContainer;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
    }
}