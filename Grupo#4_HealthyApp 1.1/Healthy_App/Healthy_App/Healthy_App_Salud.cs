using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Healthy_App
{
    public partial class Healthy_App_Salud : Form
    {
        public Healthy_App_Salud()
        {
            InitializeComponent();
        }
        private void Healthy_App_Salud_Load(object sender, EventArgs e)
        {

        }
        public string idUsuario;
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Healthy_App_Inicio i1 = new Healthy_App_Inicio();
            i1.Show();
            i1.ID_usuario = idUsuario;
            this.Close();
        } 
        private void btnIngresarSalud_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtmFecha.Value;
            string connectionString = @"Data Source=R;Initial Catalog=Healthy_App;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_InsertarSalud", connection))
                {
                    try
                    {
                        double peso = Convert.ToDouble(txtPeso.Text);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@peso", peso);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro insertado correctamente.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar el registro: " + ex.Message);
                    }
                }
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=R;Initial Catalog=Healthy_App;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DataSalud", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dtgDataSalud.DataSource = dataTable;
                }
            }
        }
        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
        DialogResult resultado = MessageBox.Show("Estas Seguro? \nEsta accion eliminara todos los datos", "Desea Elminar los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (resultado)
            {
                case DialogResult.Yes:
                    string connectionString = @"Data Source=R;Initial Catalog=Healthy_App;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("BorrarDatosUsuario", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                            DataTable dataTable = new DataTable();
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                break;
                case DialogResult.No:
                break;
            } 
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            DateTime dtmFecha = DateTime.Today;
            txtPeso.Focus();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Healthy_App_Login l2 = new Healthy_App_Login();
            l2.Show();
            this.Close();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            Healthy_App_IMCCalculator imc = new Healthy_App_IMCCalculator();
            imc.Show();
            this.Close();
        }
    }
}
