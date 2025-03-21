namespace Principal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarP agregar = new AgregarP();
            agregar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            EliminarP eliminarP = new EliminarP();
            eliminarP.ShowDialog();
        }


    }
}
