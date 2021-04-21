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
using System.Configuration;

namespace Pruebaaa
{


    public partial class Login : Form
    {
        SqlConnection Conexion = new SqlConnection();

        SqlCommand comandos;
        SqlDataReader dr;



        public Login()
        {
           
            InitializeComponent();


            SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-GAB0UPU;Initial Catalog=Afijos;Integrated Security=True");

        
        }


       /* private bool verificacion (string usuario , string clave)
        {
        
            Conexion.Open();
            //comandos.Connection=Conexion;
            string datocomand = "select * from LOGI where CORREO='"+usuario+ "and PASSWORD =" +clave+"'";
            comandos = new SqlCommand(datocomand, Conexion);
            dr = comandos.ExecuteReader();
           

            if (dr.Read())
            {
                if(Convert.ToBoolean(dr["LOGI"])==true)
                 {
                    //return true;

                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }

          
        }
       */









        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
                    }

        private void GbontonInic_Click(object sender, EventArgs e)
        {

                Form formulario = new Formbienveida();
                formulario.Show();
                Conexion.Close();
        

            

        }

        private void Glabregistro_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            formulario.Show();
        }
    }
}

