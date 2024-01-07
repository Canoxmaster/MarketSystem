using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem
{
    public partial class Visualizar : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Data Source=WIN-2HLBOJKDAEA;Initial Catalog=TuTiendaDeAbarrotes;Integrated Security=True;";
        public Visualizar()
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

        private void button7_Click(object sender, EventArgs e)
        {
            // Llama al método para visualizar todos los productos
            VisualizarProductos();
        }
        private void VisualizarProductos()
        {
            try
            {
                // Crea una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crea una consulta SQL para seleccionar todos los productos
                    string selectQuery = "SELECT * FROM Productos";

                    // Crea un adaptador de datos para llenar un DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        // Crea un DataTable para almacenar los resultados de la consulta
                        DataTable dataTable = new DataTable();

                        // Llena el DataTable con los resultados de la consulta
                        adapter.Fill(dataTable);

                        // Asigna el DataTable al DataGridView para mostrar los datos
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores: Muestra un mensaje si ocurre un error
                MessageBox.Show($"Error al visualizar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
