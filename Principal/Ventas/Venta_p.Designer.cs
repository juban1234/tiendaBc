namespace Principal.Ventas
{
    partial class Venta_p
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta_p));
            BtVende_P = new Button();
            lbResult = new Label();
            PanelContainer = new Panel();
            BtTraerProducto = new Button();
            BtBusqueda = new Button();
            TbBusqueda = new TextBox();
            btnMinizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BtVende_P
            // 
            BtVende_P.BackColor = Color.FromArgb(40, 40, 40);
            BtVende_P.FlatAppearance.BorderSize = 0;
            BtVende_P.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtVende_P.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtVende_P.FlatStyle = FlatStyle.Flat;
            BtVende_P.ForeColor = Color.LightGray;
            BtVende_P.Location = new Point(332, 432);
            BtVende_P.Name = "BtVende_P";
            BtVende_P.Size = new Size(226, 38);
            BtVende_P.TabIndex = 17;
            BtVende_P.Text = "Vender Producto";
            BtVende_P.UseVisualStyleBackColor = false;
            BtVende_P.Click += BtVende_P_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.ForeColor = Color.White;
            lbResult.Location = new Point(59, 84);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(130, 15);
            lbResult.TabIndex = 16;
            lbResult.Text = "Resultado de Busqueda";
            // 
            // PanelContainer
            // 
            PanelContainer.AutoScroll = true;
            PanelContainer.BackColor = Color.LightGray;
            PanelContainer.ForeColor = Color.White;
            PanelContainer.Location = new Point(59, 126);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(499, 279);
            PanelContainer.TabIndex = 15;
            // 
            // BtTraerProducto
            // 
            BtTraerProducto.BackColor = Color.FromArgb(40, 40, 40);
            BtTraerProducto.FlatAppearance.BorderSize = 0;
            BtTraerProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtTraerProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtTraerProducto.FlatStyle = FlatStyle.Flat;
            BtTraerProducto.ForeColor = Color.LightGray;
            BtTraerProducto.Location = new Point(59, 432);
            BtTraerProducto.Name = "BtTraerProducto";
            BtTraerProducto.Size = new Size(226, 38);
            BtTraerProducto.TabIndex = 14;
            BtTraerProducto.Text = "Inventario de  Productos ";
            BtTraerProducto.UseVisualStyleBackColor = false;
            BtTraerProducto.Click += BtTraerProducto_Click;
            // 
            // BtBusqueda
            // 
            BtBusqueda.BackColor = Color.FromArgb(40, 40, 40);
            BtBusqueda.FlatAppearance.BorderSize = 0;
            BtBusqueda.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            BtBusqueda.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtBusqueda.FlatStyle = FlatStyle.Flat;
            BtBusqueda.ForeColor = Color.LightGray;
            BtBusqueda.Location = new Point(480, 33);
            BtBusqueda.Name = "BtBusqueda";
            BtBusqueda.Size = new Size(89, 36);
            BtBusqueda.TabIndex = 13;
            BtBusqueda.Text = "Busqueda";
            BtBusqueda.UseVisualStyleBackColor = false;
            BtBusqueda.Click += BtBusqueda_Click;
            // 
            // TbBusqueda
            // 
            TbBusqueda.BackColor = Color.FromArgb(15, 15, 15);
            TbBusqueda.BorderStyle = BorderStyle.None;
            TbBusqueda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbBusqueda.ForeColor = Color.DimGray;
            TbBusqueda.Location = new Point(59, 39);
            TbBusqueda.Name = "TbBusqueda";
            TbBusqueda.PlaceholderText = "Busqueda de Productos";
            TbBusqueda.Size = new Size(383, 20);
            TbBusqueda.TabIndex = 12;
            // 
            // btnMinizar
            // 
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(639, 2);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(28, 27);
            btnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinizar.TabIndex = 18;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(673, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 19;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Venta_p
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(700, 500);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinizar);
            Controls.Add(BtVende_P);
            Controls.Add(lbResult);
            Controls.Add(PanelContainer);
            Controls.Add(BtTraerProducto);
            Controls.Add(BtBusqueda);
            Controls.Add(TbBusqueda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Venta_p";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta_p";
            Load += Venta_p_Load;
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtVende_P;
        private Label lbResult;
        private Panel PanelContainer;
        private Button BtTraerProducto;
        private Button BtBusqueda;
        private TextBox TbBusqueda;
        private PictureBox btnMinizar;
        private PictureBox btnCerrar;
    }
}