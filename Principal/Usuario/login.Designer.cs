namespace Principal
{
    partial class login
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
            btnIniciarSesion = new Button();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(89, 309);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(123, 42);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "inicar secion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(121, 110);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "usuario";
            tbUsuario.Size = new Size(100, 23);
            tbUsuario.TabIndex = 1;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(121, 182);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "contraseña";
            tbContraseña.Size = new Size(100, 23);
            tbContraseña.TabIndex = 2;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(btnIniciarSesion);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
    }
}