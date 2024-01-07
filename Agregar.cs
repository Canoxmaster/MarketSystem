using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MarketSystem
{
    public partial class Agregar : Form
    {

        string connectionString = "Data Source=WIN-2HLBOJKDAEA;Initial Catalog=TuTiendaDeAbarrotes;Integrated Security=True;";



        string selectQuery = "SELECT * FROM Productos";
        public Agregar()
        {
            InitializeComponent();
        }

        private void button5_Click_1(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los TextBoxes
            string codigo = textBox1.Text;
            string nombre = textBox2.Text;
            decimal precio = Convert.ToDecimal(textBox3.Text);  // Convierte a decimal, asumiendo que el precio es un número
            string descripcion = textBox4.Text;
            int cantidad = Convert.ToInt32(textBox5.Text);
            string categoria = textBox6.Text;

            // Llama al método para agregar datos a la base de datos
            AgregarProducto(codigo, nombre, precio, cantidad, descripcion, categoria);
        }
        private void AgregarProducto(string codigo, string nombre, decimal precio, int cantidad, string descripcion, string categoria)
        {
            try
            {
                // Crea una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crea una consulta SQL de inserción
                    string insertQuery = "INSERT INTO Productos (Codigo, Nombre, Precio, CantidadEnStock, Descripcion, Categoria) " +
                                         "VALUES (@Codigo, @Nombre, @Precio, @Cantidad, @Descripcion, @Categoria)";

                    // Crea un comando SQL con la consulta y la conexión
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Asigna los valores de los parámetros
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Categoria", categoria);

                        // Ejecuta la consulta
                        cmd.ExecuteNonQuery();

                        // Muestra un mensaje de éxito
                        MessageBox.Show("Producto agregado con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores: Muestra un mensaje si ocurre un error
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
