using System;
using System.Drawing;
using System.Windows.Forms;
using LibreriaConexion;

namespace Practitec_ProyectoF
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        string cmd;
        string nmb, apll, carr, cor, cont, depto, cel,user,pass;
        int nocot, smt;

        private void button2_Click(object sender, EventArgs e)
        {
            login L = new login();
            this.Hide();
            L.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Número de celular")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Número de celular";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "No. Control")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "No. Control";
                textBox7.ForeColor = Color.Black;
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
                textBox5.UseSystemPasswordChar = true;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Contraseña";
                textBox5.ForeColor = Color.Black;
                textBox5.UseSystemPasswordChar = false;
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Confirmar contraseña")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
                textBox6.UseSystemPasswordChar = true;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Confirmar contraseña";
                textBox6.ForeColor = Color.Black;
                textBox6.UseSystemPasswordChar = false;
            }
        }
        #endregion

        //REGISTRAR ALUMNO 
        private void btnregistro_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                nmb = textBox1.Text.Trim();
                apll = textBox2.Text.Trim();
                cor = textBox3.Text.Trim();

                user = textBox4.Text.Trim();
                pass = textBox5.Text.Trim();

                carr = comboBox1.Text.Trim();
                nocot = int.Parse(textBox7.Text.Trim());
                cel = textBox8.Text.Trim();
                smt = int.Parse(comboBox2.Text.Trim());

                try
                {
                    cmd = string.Format("EXEC ActualizarAlumnos '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'", user,pass, nocot, nmb, apll, cor, carr, smt, cel);
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
                    this.Close();
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden ");
            }
        }
    }
}
