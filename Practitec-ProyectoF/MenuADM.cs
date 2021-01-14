using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practitec_ProyectoF
{
    public partial class MenuADM : Form
    {
        public string user_admin { get; set;}

        public MenuADM(string UA)
        {
            InitializeComponent();
            user_admin = UA;
        }
        private Form formularioactivo = null;
        private void abrirformhijo(Form formHijo)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel3.Controls.Add(formHijo);
            panel3.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        } //Metodo para abrir formularios en menu
        private void label4_Click(object sender, EventArgs e)
        {
            abrirformhijo(new PerfilADM(user_admin));
        }
        private void label6_Click(object sender, EventArgs e)
        {
            abrirformhijo(new RegistroAsesores(user_admin));
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login m = new login();
            this.Close();
            m.Show();
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            abrirformhijo(new PerfilADM(user_admin));
        }

        private void btnasesor_Click(object sender, EventArgs e)
        {
            abrirformhijo(new RegistroAsesores(user_admin));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformhijo(new VinculacionAlumno());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            abrirformhijo(new VinculacionAlumno());
        }
    }
}
