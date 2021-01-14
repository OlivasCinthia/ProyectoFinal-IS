using System.Windows.Forms;
using LibreriaConexion;
using System;
using System.Data;

namespace Practitec_ProyectoF
{
    public partial class Asesor : Form
    {
        private string user_alumno{ get; set; }
        public Asesor()
        {
            InitializeComponent();
        }
        public Asesor(string UA)
        {
            InitializeComponent();
            user_alumno = UA;
            Carga_Datos();
        }

        private void Asesor_Load(object sender, System.EventArgs e)
        {

        }

        private void Carga_Datos()
        {
            string CMDA = string.Format("select * from User_asesor where Id_asesor = (Select Id_asesor FROM User_Alumno where nomb_user = '{0}')", user_alumno);
            DataSet dsAsesor = Class1.Ejecutar(CMDA);
            label6.Text = dsAsesor.Tables[0].Rows[0]["Nombre_Asesor"].ToString().Trim();
            label7.Text = dsAsesor.Tables[0].Rows[0]["Apellido_Asesor"].ToString().Trim();
            label8.Text = dsAsesor.Tables[0].Rows[0]["Departamento"].ToString().Trim();
            label9.Text = dsAsesor.Tables[0].Rows[0]["Correo_Asesor"].ToString().Trim();

        }
    }
}
