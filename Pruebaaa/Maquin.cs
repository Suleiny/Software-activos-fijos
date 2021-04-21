using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pruebaaa
{
    public partial class Maquinarias : Form
    {

        private Datos dat = new Datos();


        string coig, model, marc,  year,  cand,  vl1,  vl2,  pro, Fi;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {

              
                model = mamodelo.Text;
              


                MessageBox.Show("Actualizando Datos ....");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados...");


            }
            finally
            {


                MessageBox.Show("Actualizacion de activos Exitos....");
            }


            dat.MAQMODELO(model);
            DataG();






        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            try
            {

                coig = macodigo.Text;
                model = mamodelo.Text;
                marc = mMarca.Text;
                year = mayeard.Text;
                cand = macantidad.Text;
                vl1 = mavalor1.Text;
                vl2 = valor2.Text;
                pro = mapropietarios.Text;
                Fi = mafecha.Text;


                MessageBox.Show("Registrando datos....");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados...");


            }
            finally
            {


                MessageBox.Show("Registro de activos Exitos....");
            }


            dat.MAQUINARIAS(coig, model, marc, year, cand, vl2, vl1, pro, Fi);
            DataG();
        }

        private void carmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDIT_Click(object sender, EventArgs e)
        {

        }



        ///CONEXION DE LA BASE DE DATOS
        ///

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-GAB0UPU;Initial Catalog=Afijos;Integrated Security=True");

        SqlCommand comandos;



        private void BUSCUSER_KeyUp(object sender, KeyEventArgs e)
        {

            string prueba = "probando";











        }

        private void carMarca_TextChanged(object sender, EventArgs e)
        {

        }

        public Maquinarias()
        {
            InitializeComponent();
        }

        private void Maquinarias_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void datos_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

            


        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }


        public void DataG()
        {
            dataGridView1.DataSource = dat.DATOSMAQUINARIAS();
        }


    }
}
