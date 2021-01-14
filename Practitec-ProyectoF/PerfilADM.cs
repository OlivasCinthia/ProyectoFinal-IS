using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaConexion;

namespace Practitec_ProyectoF
{
    public partial class PerfilADM : Form
    {
        public string userADM
        { get; set; }

        public PerfilADM(string adm)
        {
            InitializeComponent();
            userADM = adm;
            Carga_Datos();
        }
        private void Carga_Datos()
        {
            string CMDA = string.Format("Select * FROM Administrador where usuarioADM = '{0}'", userADM);
            DataSet dsAdm = Class1.Ejecutar(CMDA);
            label19.Text = dsAdm.Tables[0].Rows[0]["NombreAdm"].ToString().Trim();
            label23.Text = dsAdm.Tables[0].Rows[0]["cel"].ToString().Trim();
            label18.Text = dsAdm.Tables[0].Rows[0]["usuarioADM"].ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CMD = string.Format("Select * FROM Administrador where usuarioADM = '{0}'", userADM);
            DataSet dsAdmin = Class1.Ejecutar(CMD);

            string contra = dsAdmin.Tables[0].Rows[0]["contraADM"].ToString().Trim();

            if (textBox7.Text == contra)
            {
                if (!string.IsNullOrEmpty(textBox1.Text)) //Nombre de usuario
                {
                    string CMDA2 = string.Format("UPDATE Administrador SET usuarioADM='{0}' where usuarioADM = '{1}'", textBox1.Text, userADM);
                    DataSet dsAdmin2 = Class1.Ejecutar(CMDA2);
                    userADM = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text)) //Nombre
                {
                    string CMDA2 = string.Format("UPDATE Administrador SET NombreAdm='{0}' where usuarioADM = '{1}'", textBox2.Text, userADM);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);
                }
                if (!string.IsNullOrEmpty(textBox5.Text)) //cel
                {
                    string CMDA3 = string.Format("UPDATE Administrador SET cel ='{0}' where usuarioADM = '{1}'", textBox5.Text, userADM);
                    DataSet dsAdmin3 = Class1.Ejecutar(CMDA3);
                }
                if (!string.IsNullOrEmpty(textBox9.Text))//contra
                {
                    string CMDA4 = string.Format("UPDATE Administrador SET contraADM ='{0}' where usuarioADM = '{1}'", textBox9.Text, userADM);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA4);
                }
                Carga_Datos();
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Error en la contraseña, no se pueden guardar los datos");
            }
        }

        private void PerfilADM_Load(object sender, EventArgs e)
        {

        }
    }
}
