using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_App
{
    public partial class Healthy_App_Login : Form
    {
        public Healthy_App_Login()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string IDUsuario { set; get; }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string ID_Usuario;
            int ID_Password = 0;
 
            try
            {
                ID_Usuario = txtLoginUsuario.Text;
                ID_Password = Convert.ToInt32(txtLoginPassword.Text);
                string connectionString = @"Data Source=R;Initial Catalog=Healthy_App;Integrated Security=True";
                string query = "SELECT COUNT(*) FROM login_app WHERE ID_Usuario = @NombreUsuario AND ID_Password = @Contraseña";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", ID_Usuario);
                    command.Parameters.AddWithValue("@Contraseña", ID_Password);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        Healthy_App_Salud s1 = new Healthy_App_Salud();
                        s1.idUsuario = ID_Usuario;
                        s1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no existe. Por favor, intenta nuevamente.");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error No se admiten letras ni simbolos ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Healthy_App_CrearCuenta c1 = new Healthy_App_CrearCuenta();
            c1.Show();
            this.Hide();
        }

        private void lblContra_Click(object sender, EventArgs e)
        {

        }

        private void Healthy_App_Login_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
