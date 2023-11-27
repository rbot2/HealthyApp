using System;
using System.Windows.Forms;

namespace Healthy_App
{
    public partial class Healthy_App_Inicio : Form
    {
        public Healthy_App_Inicio()
        {
            InitializeComponent();
        }
        public string ID_usuario;
        private void Healthy_App_Inicio_Load(object sender, EventArgs e)
        {
            pcbDietas.Hide();
            pcbRutinas.Hide();
            pcbVidaSana.Hide();
        }
        private void btnSaludinicio_Click(object sender, EventArgs e)
        {
            Healthy_App_Salud s1 = new Healthy_App_Salud();
            s1.idUsuario = ID_usuario;
            s1.Show();
            this.Close();
        }
        private void btnDietas_Click(object sender, EventArgs e)
        {
            pcbDietas.Show();
            pcbRutinas.Hide();
            pcbVidaSana.Hide();
        }
        private void btnRutinas_Click(object sender, EventArgs e)
        {
            pcbRutinas.Show();
            pcbDietas.Hide();
            pcbVidaSana.Hide();
        }
        private void btnVisaSana_Click(object sender, EventArgs e)
        {
            pcbVidaSana.Show();
            pcbDietas.Hide();
            pcbRutinas.Hide();
        }
        private void btnSwitchFormulario_Click(object sender, EventArgs e)
        {
            Healthy_App_Salud s1 = new Healthy_App_Salud();
            s1.idUsuario = ID_usuario;
            s1.Show();
            this.Close();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Healthy_App_Login l1 = new Healthy_App_Login();
            l1.Show();
            this.Close();
        }
    }
}
