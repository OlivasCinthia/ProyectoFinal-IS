using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConexion;
using System.Windows.Forms;

namespace Practitec_ProyectoF
{
    public partial class Alumno : Form
    {
        private string user_asesor { get; set; }
        public Alumno()
        {
            InitializeComponent();
            
        }
        public Alumno(string UA)
        {
            user_asesor = UA;
            InitializeComponent();
            string CMDA = string.Format("select [nomb_user] ,[No_ctrl] ,[Nombre_Alumno] ,[Apellido_Alumno] ,[Correo_Alumno] ,[Carrera] ,[Semestre_Alumno],[Cel_Alumno],[Id_Asesor] ,[Id_Proyecto] from User_Alumno where Id_asesor = (Select Id_asesor FROM User_Asesor where user_asesor = '{0}')", user_asesor);
            DataSet dsAsesor = Class1.Ejecutar(CMDA);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dsAsesor.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
