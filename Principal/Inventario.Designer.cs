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
            btGuardar = new Button();
            tbNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            Resultado1 = new Label();
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
            lbResult.Location = new Point(120, 364);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(17, 15);
            lbResult.TabIndex = 1;
            lbResult.Text = "gl";
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
            // btGuardar
            // 
            btGuardar.Location = new Point(643, 364);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(131, 58);
            btGuardar.TabIndex = 6;
            btGuardar.Text = "Guardar  ";
            btGuardar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(311, 148);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(278, 23);
            tbNombre.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 239);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 19;
            label5.Text = "precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 198);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 17;
            label4.Text = "descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 280);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 18;
            label3.Text = "cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 151);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 16;
            label2.Text = "nombre";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(311, 277);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(278, 23);
            tbCantidad.TabIndex = 15;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(311, 236);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(278, 23);
            tbPrecio.TabIndex = 14;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(311, 195);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(278, 23);
            tbDescripcion.TabIndex = 13;
            // 
            // Resultado1
            // 
            Resultado1.AutoSize = true;
            Resultado1.Location = new Point(281, 342);
            Resultado1.Name = "Resultado1";
            Resultado1.Size = new Size(30, 15);
            Resultado1.TabIndex = 21;
            Resultado1.Text = "gokl";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado1);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(btGuardar);
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
        private Button btGuardar;
        private TextBox tbNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
        private Label Resultado1;
    }
}