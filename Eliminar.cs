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
    public partial class Eliminar : Form
    {

        string connectionString = "Data Source=WIN-2HLBOJKDAEA;Initial Catalog=TuTiendaDeAbarrotes;Integrated Security=True;";
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Agregar agregar = new Agregar();
            agregar.Show();
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
            // Obtén el código del producto a eliminar desde el TextBox
            string codigoEliminar = textBox1.Text;

            // Llama al método para eliminar el producto
            EliminarProducto(codigoEliminar);
        }
        private void EliminarProducto(string codigoEliminar)
        {
            try
            {
                // Crea una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crea una consulta SQL de eliminación
                    string deleteQuery = "DELETE FROM Productos WHERE Codigo = @Codigo";

                    // Crea un comando SQL con la consulta y la conexión
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Asigna el valor del parámetro
                        cmd.Parameters.AddWithValue("@Codigo", codigoEliminar);

                        // Ejecuta la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verifica si se eliminó algún producto
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con el código especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores: Muestra un mensaje si ocurre un error
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
