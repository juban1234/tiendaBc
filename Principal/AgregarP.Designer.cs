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
            label1 = new Label();
            btAgregar = new Button();
            tbResultado = new Label();
            tbImagen = new TextBox();
            tbNombre = new TextBox();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 26);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 5;
            label1.Text = "Agregar producto";
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(39, 326);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(278, 56);
            btAgregar.TabIndex = 6;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // tbResultado
            // 
            tbResultado.AutoSize = true;
            tbResultado.Location = new Point(555, 187);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(0, 15);
            tbResultado.TabIndex = 7;
            // 
            // tbImagen
            // 
            tbImagen.Location = new Point(39, 268);
            tbImagen.Name = "tbImagen";
            tbImagen.PlaceholderText = "imagen";
            tbImagen.Size = new Size(278, 23);
            tbImagen.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(39, 89);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "nombre";
            tbNombre.Size = new Size(278, 23);
            tbNombre.TabIndex = 42;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(39, 223);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.PlaceholderText = "cantidad";
            tbCantidad.Size = new Size(278, 23);
            tbCantidad.TabIndex = 41;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(39, 180);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "presio";
            tbPrecio.Size = new Size(278, 23);
            tbPrecio.TabIndex = 40;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(39, 136);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "descripcion";
            tbDescripcion.Size = new Size(278, 23);
            tbDescripcion.TabIndex = 39;
            // 
            // AgregarP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(tbResultado);
            Controls.Add(btAgregar);
            Controls.Add(label1);
            Controls.Add(tbImagen);
            Name = "AgregarP";
            Text = "AgregarP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btAgregar;
        private Label tbResultado;
        private TextBox tbImagen;
        private TextBox tbNombre;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
    }
}