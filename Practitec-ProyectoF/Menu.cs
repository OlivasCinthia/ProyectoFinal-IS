﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Practitec_ProyectoF
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        public string user_alumno {get;set; }
        
        public Menu(string UA)
        {
            InitializeComponent();
            user_alumno = UA;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region formularioshijos
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

        private void label3_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil(user_alumno));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil(user_alumno));
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Perfil(user_alumno));
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Asesor(user_alumno));

        }

        private void btnasesor_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Asesor(user_alumno));

        }

        private void label9_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Proyecto());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Proyecto());
        }

        private void btnproyecto_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Proyecto());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Ajustes());
        }

        private void btnajustes_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Ajustes());
        }


        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
