namespace MarketSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venta venta = new Venta();
            venta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte reporte = new Reporte();
            reporte.Show();
        }
    }
}