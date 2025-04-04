namespace Principal
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventario = new Button();
            ventas = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // inventario
            // 
            inventario.Location = new Point(28, 124);
            inventario.Name = "inventario";
            inventario.Size = new Size(175, 52);
            inventario.TabIndex = 1;
            inventario.Text = "inventario";
            inventario.UseVisualStyleBackColor = true;
            inventario.Click += inventario_Click;
            // 
            // ventas
            // 
            ventas.Location = new Point(28, 203);
            ventas.Name = "ventas";
            ventas.Size = new Size(175, 52);
            ventas.TabIndex = 2;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = true;
            ventas.Click += ventas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 4;
            label1.Text = "Tienda";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ventas);
            Controls.Add(inventario);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button inventario;
        private Button ventas;
        private Label label1;
    }
}
