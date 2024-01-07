using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem
{
    public partial class Venta : Form
    {
        private DataTable dt;
        string connectionString = "Data Source=WIN-2HLBOJKDAEA;Initial Catalog=TuTiendaDeAbarrotes;Integrated Security=True;";
        private double subTotal = 0;
        private double total = 0;
        public Venta()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio x unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio Total");

            dataGridView1.DataSource = dt;


        }
        public Tuple<string, string, string, string> consulta(string codigo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Productos where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Tuple.Create(reader["Nombre"].ToString(), reader["Precio"].ToString(), reader["Categoria"].ToString(), reader["Descripcion"].ToString());
                connection.Close();
            }

            else
            {
                return Tuple.Create("Null", "", "", "");
                connection.Close();

            }

        }
        private void Venta_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos productos = new Productos();
            productos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox3.Visible = true;
            var resultado = consulta(textBox1.Text);
            DataRow row = dt.NewRow();
            row["Codigo"] = textBox1.Text;
            row["Nombre"] = resultado.Item1;
            row["Categoria"] = resultado.Item3;
            row["Descripcion"] = resultado.Item4;
            row["Precio x unidad"] = resultado.Item2;

            row["Cantidad"] = textBox2.Text;
            double precioTotal = Int32.Parse(textBox2.Text) * double.Parse(resultado.Item2);
            row["Precio Total"] = precioTotal;
            dt.Rows.Add(row);
            subTotal = subTotal + precioTotal;
            label3.Text = subTotal.ToString();

            // Realizar la actualización del stock en la base de datos
            string stockQuery = "SELECT CantidadEnStock FROM Productos WHERE Nombre = '" + resultado.Item1 + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand stockCmd = new SqlCommand(stockQuery, connection);
            double stockActual = Convert.ToDouble(stockCmd.ExecuteScalar());

            double compra = Convert.ToDouble(textBox2.Text);
            double nuevaCantidad = stockActual - compra;

            string actualizacion = "UPDATE Productos SET CantidadEnStock = @NuevaCantidad WHERE Nombre = @NombreProducto";

            SqlCommand actualizacionCmd = new SqlCommand(actualizacion, connection);
            actualizacionCmd.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
            actualizacionCmd.Parameters.AddWithValue("@NombreProducto", resultado.Item1);

            int filasActualizadas = actualizacionCmd.ExecuteNonQuery();


            connection.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            double cambio = double.Parse(textBox3.Text) - subTotal;
            MessageBox.Show($"El cliente realizo una compra de {subTotal}$ y pago con {textBox3.Text}$, usted debe dar {cambio}$ de cambio");
        }
    }

}
