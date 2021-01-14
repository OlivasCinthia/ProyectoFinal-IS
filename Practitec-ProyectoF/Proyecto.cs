using System.Windows.Forms;
using LibreriaConexion;
using System;

namespace Practitec_ProyectoF
{
    public partial class Proyecto : Form
    {
        string nom, org, per;
        int cntr;
        string cmd;

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Close();
            f.Show();
        }

        public Proyecto()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, System.EventArgs e)
        {   //VALIDACION DE CAMPOS LLENOS
            if (textBox1.Text != "Nombre Proyecto" & textBox2.Text != "Periodo Ej.2021-1" & comboBox2.Text != "Cantidad recidentes" & comboBox1.Text!="Origen" & textBox1.Text != null & textBox2.Text != null & comboBox2.Text != null & comboBox1.Text != null)
            {
                //ASIGNACION DE LOS DATOS EN VARIABLES
                nom = textBox1.Text;
                org = comboBox1.Text;
                per = textBox2.Text;
                cntr = int.Parse(comboBox2.Text);

                try
                {   //DAR DE ALTA PROYECTO
                    cmd = string.Format("EXEC ActualizarProyecto '{0}','{1}','{2}','{3}'", nom, org, per, cntr);
                    Class1.Ejecutar(cmd);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:  " + error.Message);
                }

                finally
                {
                    MessageBox.Show("Datos ingresados correctamente");
                    Menu f = new Menu();
                    this.Close();
                    f.Show();
                }
            }
            else 
                MessageBox.Show("Lenar todos los campos");
        }
    }
}
