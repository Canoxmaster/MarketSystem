using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contrasena = textBox2.Text;

            // Realiza la verificación del nombre de usuario y contraseña en la base de datos
            if (VerificarCredenciales(nombreUsuario, contrasena))
            {
                // Inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Main main = new Main();
                main.Show();
                
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerificarCredenciales(string usuario, string contrasena)
        {
            // Cadena de conexión a tu base de datos
            string cadenaConexion = "Data Source=WIN-2HLBOJKDAEA;Initial Catalog=TuTiendaDeAbarrotes;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                // Consulta SQL para verificar las credenciales
                string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario = @Usuario AND Contrasena = @Contrasena";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows; // Si hay filas, las credenciales son correctas
                    }
                }
            }
        }
    }
}
