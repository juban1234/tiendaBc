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
        private void InitializeComponent()
        {
            btTraerProducto = new Button();
            lbResult = new Label();
            btEditarP = new Button();
            lbBusqueda = new Label();
            textBox1 = new TextBox();
            btBusqueda = new Button();
            SuspendLayout();
            // 
            // btTraerProducto
            // 
            btTraerProducto.Location = new Point(32, 142);
            btTraerProducto.Name = "btTraerProducto";
            btTraerProducto.Size = new Size(131, 58);
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
            btEditarP.Location = new Point(32, 226);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(131, 61);
            btEditarP.TabIndex = 2;
            btEditarP.Text = "editar productos";
            btEditarP.UseVisualStyleBackColor = true;
            btEditarP.Click += btEditarP_Click;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(70, 66);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(116, 15);
            lbBusqueda.TabIndex = 3;
            lbBusqueda.Text = "Busqueda productos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 4;
            // 
            // btBusqueda
            // 
            btBusqueda.Location = new Point(679, 67);
            btBusqueda.Name = "btBusqueda";
            btBusqueda.Size = new Size(75, 23);
            btBusqueda.TabIndex = 5;
            btBusqueda.Text = "busqueda";
            btBusqueda.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btBusqueda);
            Controls.Add(textBox1);
            Controls.Add(lbBusqueda);
            Controls.Add(btEditarP);
            Controls.Add(lbResult);
            Controls.Add(btTraerProducto);
            Name = "Inventario";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btTraerProducto;
        private Label lbResult;
        private Button btEditarP;
        private Label lbBusqueda;
        private TextBox textBox1;
        private Button btBusqueda;
    }
}