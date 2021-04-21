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
    public partial class Registro : Form
    {

        string nombre, user, clave;

        Datos dat = new Datos();
       
        public Registro()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();

           
            try
            {

            nombre = usuarionombre.Text;
            user = correouser.Text;
            clave = claveuser.Text;

         

                
            }

            catch (Exception)

            {


                MessageBox.Show("Revisar los datos insertados");


            }

            finally
            {
                MessageBox.Show("Registrando datos..");
                MessageBox.Show("Registro Exitoso..");
            }

            dat.Register(nombre, user, clave);
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
