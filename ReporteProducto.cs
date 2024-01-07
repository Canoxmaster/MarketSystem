﻿using System;
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
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos productos = new Productos();
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Venta venta = new Venta();
            venta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.Show();
        }
    }
}
