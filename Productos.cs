using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Agregar agregar = new Agregar();
            agregar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Visualizar visualizar = new Visualizar();
            visualizar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Venta venta = new Venta();
            venta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Reporte reporte = new Reporte();
            reporte.Show();
        }
    }
}
