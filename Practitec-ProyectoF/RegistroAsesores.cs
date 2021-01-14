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
    public partial class RegistroAsesores : Form
    {
        string cmd;
        string nmb, apll, depto, correo, tipoAs, cel, user, pass;
        public string user_admin { get; set; }
        public RegistroAsesores(string UA)
        {
            InitializeComponent();
            user_admin = UA;

        }        
        private void btnregistro_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                nmb = textBox1.Text.Trim();
                apll = textBox2.Text.Trim();
                correo = textBox3.Text.Trim();

                user = textBox4.Text.Trim();
                pass = textBox5.Text.Trim();

                depto = comboBox1.Text.Trim();
                tipoAs = comboBox2.Text.Trim();

                try
                {
                    cmd = string.Format("EXEC ActualizarAsesor '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", user, pass, nmb, apll, depto, correo,tipoAs);
                    Class1.Ejecutar(cmd);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:  " + error.Message);
                }

                finally
                {
                    MessageBox.Show("Datos ingresados correctamente");
                    login f = new login();
                    this.Hide();
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden ");
            }
        }

        #region enunciados
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombres")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nombres";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Apellidos")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Apellidos";
                textBox2.ForeColor = Color.Black;
            }
        }      

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Correo")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Correo";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Nombre de usuario")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Nombre de usuario";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Contraseña")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Contraseña";
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Confirmar contraseña")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Confirmar contraseña";
                textBox6.ForeColor = Color.Black;
            }
        }
        #endregion
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
