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
    public partial class Edificio : Form
    {

        private Datos dat = new Datos();

        string catast,  metr,  ubic, cantid, val1,  val2,  fech, deud,  due, titl;

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            try
            {

                catast = Txtcatastro.Text;
                metr = txtmetro.Text;
                ubic = txtubicacion.Text;
                val1 = txtvalor1.Text;
                val2 = txtvalor2.Text;
                deud = txtdeuda.Text;
                cantid = txtcarcantidad.Text;
                fech = txtcarfecha.Text;
                due = txtcarpropietarios.Text;
                titl = titulo.Text;



                MessageBox.Show("Registrando datos...");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados....");

            }
            finally
            {

                MessageBox.Show("Registro de activo Exitoso...");
            }


            dat.EDIFICACION(catast, metr, ubic, val2, val1, titl, due, cantid, deud, fech);
            DataG();








        }

        private void BUSCUSER_KeyUp(object sender, KeyEventArgs e)
        {


            dataGridView1.DataSource = dat.DATOSEDIFCIO();
        }

        public Edificio()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }

        public void DataG()
        {
            dataGridView1.DataSource = dat.DATOSEDIFCIO();        
        }


    }
}
