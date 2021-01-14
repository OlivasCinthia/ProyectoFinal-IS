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
    public partial class MenuS : Form
    {
        public string usuario;
        public MenuS()
        {
            InitializeComponent();
        }
        public MenuS(string user)
        {
            InitializeComponent();
            usuario = user;
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
        private void btnperfil_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnasesor_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Alumno(usuario));

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login m = new login();
            this.Close();
            m.Show();
        }
    }
}
