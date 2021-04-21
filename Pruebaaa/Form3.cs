using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebaaa
{
    public partial class Usuario : Form
    {


        string nom, apell,cedula, fecha2, fecha1, sueldo,  cel,  tel, email, direc,  estdo;
        string ocup;


        private Datos dat = new Datos();
        

        public Usuario()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {

                nom = Pnombre.Text;
                apell = Papellido.Text;
                cedula = Pcedula.Text;
                fecha1 = guna2TextBox3.Text;
                direc = direccionp.Text;
                email = Gemail.Text;
                cel = celular.Text;
                tel = telf.Text;                
                estdo = soltero.Text;
                ocup = Pempleo.Text;
                fecha2 = fechaig.Text;
                sueldo = Salario.Text;

                MessageBox.Show("Registrando datos..");



            }
            catch
            {

                MessageBox.Show("Revisar los datos insetados...");
            }
            finally
            {


                MessageBox.Show("Registro de empleado exitoso...");
            }




            dat.EMPLEADOS(apell, nom, cedula, cel, tel, sueldo, fecha1, fecha2, ocup, email, estdo, direc);
            Limpiar();



        }



        public void Limpiar()
        {
            foreach (Control tour in Controls)

            {
                if (tour is TextBox)
                {
                    tour.Text = "";
                }
            }


        }



    }
}
