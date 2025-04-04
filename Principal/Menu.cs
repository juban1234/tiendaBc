

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
            Inventario inventario = new Inventario();
            ShowDialog(inventario);
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Ventas inventas = new Ventas();
            ShowDialog(inventas);
        }
    }
}
