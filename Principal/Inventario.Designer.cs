namespace Principal
{
    partial class Inventario
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
        /// 
        private Panel panelContainer;
        private void InitializeComponent()
        {
            btTraerProducto = new Button();
            lbResult = new Label();
            btEditarP = new Button();
            textBox1 = new TextBox();
            btBusqueda = new Button();
            panelContainer = new Panel();
            btAgregarProve = new Button();
            btEliminarP = new Button();
            btAgregarP = new Button();
            SuspendLayout();
            // 
            // btTraerProducto
            // 
            btTraerProducto.Location = new Point(26, 271);
            btTraerProducto.Name = "btTraerProducto";
            btTraerProducto.Size = new Size(131, 38);
            btTraerProducto.TabIndex = 0;
            btTraerProducto.Text = "inventario de  productos ";
            btTraerProducto.UseVisualStyleBackColor = true;
            btTraerProducto.Click += btTraerProducto_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(299, 151);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 15);
            lbResult.TabIndex = 1;
            // 
            // btEditarP
            // 
            btEditarP.Location = new Point(26, 171);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(131, 32);
            btEditarP.TabIndex = 2;
            btEditarP.Text = "editar producto";
            btEditarP.UseVisualStyleBackColor = true;
            btEditarP.Click += btEditarP_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda productos";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 4;
            // 
            // btBusqueda
            // 
            btBusqueda.Location = new Point(449, 40);
            btBusqueda.Name = "btBusqueda";
            btBusqueda.Size = new Size(75, 23);
            btBusqueda.TabIndex = 5;
            btBusqueda.Text = "busqueda";
            btBusqueda.UseVisualStyleBackColor = true;
            btBusqueda.Click += btBusqueda_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.Location = new Point(266, 122);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(454, 294);
            panelContainer.TabIndex = 6;
            // 
            // btAgregarProve
            // 
            btAgregarProve.Location = new Point(26, 333);
            btAgregarProve.Name = "btAgregarProve";
            btAgregarProve.Size = new Size(131, 35);
            btAgregarProve.TabIndex = 7;
            btAgregarProve.Text = "agregar proveedores";
            btAgregarProve.UseVisualStyleBackColor = true;
            btAgregarProve.Click += btAgregarProve_Click;
            // 
            // btEliminarP
            // 
            btEliminarP.Location = new Point(26, 221);
            btEliminarP.Name = "btEliminarP";
            btEliminarP.Size = new Size(131, 32);
            btEliminarP.TabIndex = 8;
            btEliminarP.Text = "Elimiar productos";
            btEliminarP.UseVisualStyleBackColor = true;
            btEliminarP.Click += btEliminarP_Click;
            // 
            // btAgregarP
            // 
            btAgregarP.Location = new Point(26, 122);
            btAgregarP.Name = "btAgregarP";
            btAgregarP.Size = new Size(131, 32);
            btAgregarP.TabIndex = 9;
            btAgregarP.Text = "agregar producto";
            btAgregarP.UseVisualStyleBackColor = true;
            btAgregarP.Click += btAgregarP_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btAgregarP);
            Controls.Add(btEliminarP);
            Controls.Add(btAgregarProve);
            Controls.Add(btBusqueda);
            Controls.Add(textBox1);
            Controls.Add(btEditarP);
            Controls.Add(lbResult);
            Controls.Add(btTraerProducto);
            Controls.Add(panelContainer);
            Name = "Inventario";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btTraerProducto;
        private Label lbResult;
        private Button btEditarP;
        private TextBox textBox1;
        private Button btBusqueda;
        private Button btAgregarProve;
        private Button btEliminarP;
        private Button btAgregarP;
    }
}