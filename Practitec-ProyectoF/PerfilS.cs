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
using System.IO;

namespace Practitec_ProyectoF
{
    public partial class PerfilS : Form
    {
        public string usuario
        { get; set; }
        public PerfilS(string user)
        {
            InitializeComponent();
            usuario = user;
            Carga_Datos();
        }
        private void Carga_Datos()
        {
            string CMDA = string.Format("Select * FROM user_asesor where user_asesor = '{0}'", usuario);
            DataSet dsAlumno = Class1.Ejecutar(CMDA);
            label18.Text = dsAlumno.Tables[0].Rows[0]["user_asesor"].ToString().Trim();
            label19.Text = dsAlumno.Tables[0].Rows[0]["Nombre_Asesor"].ToString().Trim();
            label20.Text = dsAlumno.Tables[0].Rows[0]["Apellido_Asesor"].ToString().Trim();
            label21.Text = dsAlumno.Tables[0].Rows[0]["Correo_Asesor"].ToString().Trim();
            label22.Text = dsAlumno.Tables[0].Rows[0]["TipoAsesor"].ToString().Trim();
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CMDA = string.Format("Select * FROM User_Alumno where nomb_user = '{0}'", usuario);
            DataSet dsAlumno = Class1.Ejecutar(CMDA);
            string contra = dsAlumno.Tables[0].Rows[0]["Contra_Alumno"].ToString().Trim();

            if (textBox7.Text == textBox8.Text & !string.IsNullOrEmpty(textBox7.Text) & textBox7.Text == contra)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET nomb_user='{1}' where nomb_user = '{0}'", usuario, textBox1.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);
                    usuario = textBox1.Text;


                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET Nombre_Alumno='{1}' where nomb_user = '{0}'", usuario, textBox2.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);


                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET Apellido_Alumno='{1}' where nomb_user = '{0}'", usuario, textBox3.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);


                }
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET No_Ctrl='{1}' where nomb_user = '{0}'", usuario, textBox4.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);

                }
                /*if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET Cel_Alumno='{1}' where nomb_user = '{0}'", usuario, textBox5.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);
                }*/
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET Correo_Alumno='{1}' where nomb_user = '{0}'", usuario, textBox6.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);


                }
                if (!string.IsNullOrEmpty(textBox9.Text))
                {
                    string CMDA2 = string.Format("UPDATE User_Alumno SET Contra_Alumno='{1}' where nomb_user = '{0}'", usuario, textBox9.Text);
                    DataSet dsAlumno2 = Class1.Ejecutar(CMDA2);


                }
                Carga_Datos();
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Las Contraseñas no coinciden", "Error");

            }

        }
    }
}
