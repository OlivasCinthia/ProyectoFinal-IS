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
    public partial class VinculacionAlumno : Form
    {
        
        public VinculacionAlumno()
        {
            InitializeComponent();
            Carga_Datos();
        }

        private void Carga_Datos()
        {
            comboBox1.Items.Clear();
            string CMDA = string.Format("Select * FROM User_Asesor" );
            DataSet dsAlumno = Class1.Ejecutar(CMDA);
            for (int i = 0; i < dsAlumno.Tables[0].Rows.Count; i++)
            {
                string nombre = dsAlumno.Tables[0].Rows[i]["Nombre_Asesor"].ToString().Trim();
                string apellido = dsAlumno.Tables[0].Rows[i]["Apellido_Asesor"].ToString().Trim();
                comboBox1.Items.Add(nombre + " " + apellido);

            }
        }
        private void VinculacionAlumno_Load(object sender, EventArgs e)
        {

        }
        //VINCULAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMDA = string.Format("Update user_alumno set id_asesor = '{1}' where No_Ctrl = '{0}'", textBox1.Text, comboBox1.SelectedIndex+1);
                DataSet dsAlumno = Class1.Ejecutar(CMDA);
                label4.Show();
                label4.Text = "Vinculacion completada";
            }
            catch (Exception)
            {
                label4.Show();
                label4.Text="Hubo un error al ejecutar el comando";
            }

            
            



        }
        //DESVINCULAR
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string CMDA = string.Format("Update user_alumno set id_asesor = null where No_Ctrl = '{0}'",textBox1.Text);
                DataSet dsAlumno = Class1.Ejecutar(CMDA);
                label4.Show();
                label4.Text = "Desvinculacion completada";
            }
            catch (Exception)
            {
                label4.Show();
                label4.Text = "Hubo un error al ejecutar el comando";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CMDA = string.Format("select * From user_asesor where id_asesor = '{0}'", comboBox1.SelectedIndex + 1);
            DataSet dsAlumno = Class1.Ejecutar(CMDA);
            label9.Text = dsAlumno.Tables[0].Rows[0]["departamento"].ToString().Trim();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string CMDA = string.Format("select * From user_alumno where No_Ctrl = '{0}'", textBox1.Text);
                DataSet dsAlumno = Class1.Ejecutar(CMDA);
                label19.Text = dsAlumno.Tables[0].Rows[0]["nombre_alumno"].ToString().Trim();
                label23.Text = dsAlumno.Tables[0].Rows[0]["apellido_alumno"].ToString().Trim();
                label18.Text = dsAlumno.Tables[0].Rows[0]["carrera"].ToString().Trim();

            }
            catch (Exception)
            {
                label19.Text = "Nombre";
                label23.Text = "Apellido";
                label18.Text = "Carrera";
            }


        }
    }
}
