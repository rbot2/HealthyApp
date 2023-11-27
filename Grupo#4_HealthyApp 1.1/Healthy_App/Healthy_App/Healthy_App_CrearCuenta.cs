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
namespace Healthy_App
{
    public partial class Healthy_App_CrearCuenta : Form
    {
        public Healthy_App_CrearCuenta()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRegresoLogin_Click(object sender, EventArgs e)
        {
            Healthy_App_Login r1 = new Healthy_App_Login();
            r1.Show();
            this.Hide();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string CrearUsuario;
            int CrearContra = 0;
            CrearUsuario = txtCrearUsuario.Text;
            try
            {
                CrearContra = Convert.ToInt32(txtCrearContra.Text);
            }
            catch
            {
                MessageBox.Show("Error No se admiten letras ni simbolos ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string connectionString = @"Data Source=R;Initial Catalog=Healthy_App;Integrated Security=True";
            string createAccountQuery = "INSERT INTO create_account (ID_CrearUsuario, ID_CrearPassword) VALUES (@NombreUsuario, @Contraseña)";
            string loginAppQuery = "INSERT INTO login_app (ID_Usuario, ID_Password) VALUES (@NombreUsuario, @Contraseña)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    using (SqlCommand createAccountCommand = new SqlCommand(createAccountQuery, connection))
                    {
                        createAccountCommand.Parameters.AddWithValue("@NombreUsuario", CrearUsuario);
                        createAccountCommand.Parameters.AddWithValue("@Contraseña", CrearContra);

                        createAccountCommand.ExecuteNonQuery();
                    }
                    using (SqlCommand loginAppCommand = new SqlCommand(loginAppQuery, connection))
                    {
                        loginAppCommand.Parameters.AddWithValue("@NombreUsuario", CrearUsuario);
                        loginAppCommand.Parameters.AddWithValue("@Contraseña", CrearContra);

                        loginAppCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Cuenta creada exitosamente.");
                    }
                }
                catch 
                {
                    MessageBox.Show("Cuenta Ya existe");
                }

            }
        }

        private void Healthy_App_CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void lblCrearPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
