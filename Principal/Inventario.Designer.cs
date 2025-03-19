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
            SuspendLayout();
            // 
            // btTraerProducto
            // 
            btTraerProducto.Location = new Point(108, 96);
            btTraerProducto.Name = "btTraerProducto";
            btTraerProducto.Size = new Size(75, 23);
            btTraerProducto.TabIndex = 0;
            btTraerProducto.Text = "productos";
            btTraerProducto.UseVisualStyleBackColor = true;
            btTraerProducto.Click += btTraerProducto_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(122, 203);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(38, 15);
            lbResult.TabIndex = 1;
            lbResult.Text = "label1";
            // 
            // btEditarP
            // 
            btEditarP.Location = new Point(301, 96);
            btEditarP.Name = "btEditarP";
            btEditarP.Size = new Size(75, 23);
            btEditarP.TabIndex = 2;
            btEditarP.Text = "editar producto";
            btEditarP.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}