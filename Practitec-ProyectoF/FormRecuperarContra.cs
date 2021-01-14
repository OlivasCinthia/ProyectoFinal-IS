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
    public partial class FormRecuperarContra : Form
    {
        public FormRecuperarContra()
        {
            InitializeComponent();
        }

        public string RecuperarContra(string peticion)
        {
            string CMD = string.Format("Select * FROM User_Alumno where nomb_user = '{0}' OR Correo_Alumno = '{1}'", peticion, peticion);
            DataSet dsAlumno = Class1.Ejecutar(CMD);

            if (dsAlumno.Tables[0].Rows.Count == 1)
            {
                string usuarioAlumno = dsAlumno.Tables[0].Rows[0]["nomb_user"].ToString().Trim();
                string correo_Alumno = dsAlumno.Tables[0].Rows[0]["Correo_Alumno"].ToString().Trim();

                string contra = string.Format("Select Contra_Alumno FROM User_Alumno where nomb_user = '{0}' OR Correo_Alumno = '{1}'", usuarioAlumno, correo_Alumno);
                DataSet contra_Alumno = Class1.Ejecutar(contra);

                if (contra_Alumno.Tables[0].Rows.Count == 1)
                {
                    string pass = contra_Alumno.Tables[0].Rows[0]["Contra_Alumno"].ToString().Trim();
                    var sc = new AdministrarCorreos();

                    sc.sendMail(
                        subject: "SYSTEM: Solicitud de recuperación de contraseña",
                        body: "Hola, " + usuarioAlumno + "\nRecibimos su solicitud para recuperar la contraseña. \n" +
                        "Su contraseña es: " + pass + "\nFavor de cambiar su contraseña al entrar al sistema.",
                        correodestinatario: new List<string> { correo_Alumno }
                        );
                }
                return "Hola, " + usuarioAlumno + "\nRecibimos su solicitud para recuperar la contraseña. \n" +
                    "Por favor verificar la bandeja de entrada en el correo: " + correo_Alumno + "\nFavor de cambiar su contraseña al entrar al sistema.";

            }
            else
                return "Lo sentimos no cuenta con una cuenta con ese correo o nombre de usuario";
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            var result = RecuperarContra(textBox1.Text.Trim());
            label2.Text = result;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }
    }
}
