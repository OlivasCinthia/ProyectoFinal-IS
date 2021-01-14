using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaConexion;

namespace Practitec_ProyectoF
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region enunciados
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            this.Hide();
            r.Show();

        }
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }
        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Black;
            }
        }
        private void btnacceder_Click(object sender, EventArgs e)
        {
            //ALUMNO LOGIN
            string CMDA = string.Format("Select * FROM User_Alumno where nomb_user = '{0}' AND Contra_Alumno = '{1}'", txtusuario.Text.Trim(), txtcontra.Text.Trim());
            DataSet dsAlumno = Class1.Ejecutar(CMDA);


            //ASESOR LOGIN
            string CMDS = string.Format("Select * FROM User_Asesor where user_asesor = '{0}' AND Contra_asesor = '{1}'", txtusuario.Text.Trim(), txtcontra.Text.Trim());
            DataSet dsAsesor = Class1.Ejecutar(CMDS);

            //Comparaciones
            if (dsAlumno.Tables[0].Rows.Count == 1)
            {
                string cuenta_Alumno = dsAlumno.Tables[0].Rows[0]["nomb_user"].ToString().Trim();
                string contra_Alumno = dsAlumno.Tables[0].Rows[0]["Contra_Alumno"].ToString().Trim();
                if (cuenta_Alumno == txtusuario.Text.Trim() && contra_Alumno == txtcontra.Text.Trim())
                {
                    Menu m = new Menu(cuenta_Alumno);
                    m.Show();
                }
            }
            else if (dsAsesor.Tables[0].Rows.Count == 1)
            {
                string cuenta_Asesor = dsAsesor.Tables[0].Rows[0]["user_asesor"].ToString().Trim();
                string contra_Asesor = dsAsesor.Tables[0].Rows[0]["Contra_asesor"].ToString().Trim();
                if (cuenta_Asesor == txtusuario.Text.Trim() && contra_Asesor == txtcontra.Text.Trim())
                {
                    MenuS m = new MenuS(cuenta_Asesor );
                    m.Show();
                }
            }

            else
                MessageBox.Show("Usuario o contraseña incorrecto");

        }
        private void txtcontra_Enter(object sender, EventArgs e)
        {
            if (txtcontra.Text == "Contraseña")
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.Black;
                txtcontra.UseSystemPasswordChar = true;
            }
        }
        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                txtcontra.Text = "Contraseña";
                txtcontra.ForeColor = Color.Black;
                txtcontra.UseSystemPasswordChar = false;

            }
        }
        #endregion


    }
}
