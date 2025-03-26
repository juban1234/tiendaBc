using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class AgregarProve : Form
    {
        public AgregarProve()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbCantidad = new TextBox();
            tbPrecio = new TextBox();
            tbDescripcion = new TextBox();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(38, 44);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "nombre";
            tbNombre.Size = new Size(278, 23);
            tbNombre.TabIndex = 46;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(38, 178);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.PlaceholderText = "cantidad";
            tbCantidad.Size = new Size(278, 23);
            tbCantidad.TabIndex = 45;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(38, 135);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "presio";
            tbPrecio.Size = new Size(278, 23);
            tbPrecio.TabIndex = 44;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(38, 91);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "descripcion";
            tbDescripcion.Size = new Size(278, 23);
            tbDescripcion.TabIndex = 43;
            // 
            // AgregarProve
            // 
            ClientSize = new Size(577, 451);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidad);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Name = "AgregarProve";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox tbNombre;
        private TextBox tbCantidad;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
    }
}
