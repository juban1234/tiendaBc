namespace Principal
{
    partial class EditarUsuario
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
            btEditarP = new Button();
            label1 = new Label();
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
            // btEditarP
            // 
            btEditarP.Location = new Point(29, 254);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(131, 61);
            btEditarP.TabIndex = 40;
            btEditarP.Text = "editar productos";
            btEditarP.UseVisualStyleBackColor = true;
            btEditarP.Click += btEditarP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 39;
            label1.Text = "Editar producto";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(112, 85);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(278, 23);
            tbNombre.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 176);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 37;
            label5.Text = "precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 132);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 35;
            label4.Text = "descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 222);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 36;
            label3.Text = "cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 34;
            label2.Text = "nombre";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(112, 219);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(278, 23);
            tbCantidad.TabIndex = 33;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(112, 176);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(278, 23);
            tbPrecio.TabIndex = 32;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(112, 132);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(278, 23);
            tbDescripcion.TabIndex = 31;
            // 
            // Resultado1
            // 
            Resultado1.AutoSize = true;
            Resultado1.Location = new Point(478, 108);
            Resultado1.Name = "Resultado1";
            Resultado1.Size = new Size(30, 15);
            Resultado1.TabIndex = 41;
            Resultado1.Text = "gokl";
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 357);
            Controls.Add(Resultado1);
            Controls.Add(btEditarP);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Name = "EditarUsuario";
            Text = "EditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditarP;
        private Label label1;
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