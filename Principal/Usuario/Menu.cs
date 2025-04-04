

namespace Principal
{
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            InventarioP inventario = new InventarioP();
            inventario.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            
        }
    }
}
