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
    public partial class Propiedad5 : Form
    {
        private Datos dat = new Datos();

        string catas,  met, ubiccacion,  cantidad,  valori, valrf, fecha,  deu, propie,  titulo;


        public Propiedad5()
        {
            InitializeComponent();
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                catas = catastro.Text;
                met = metro.Text;
                ubiccacion = cascantidad.Text;
                valori = valor1.Text;
                valrf = valor2.Text;
                cantidad = cascantidad.Text;
                deu = deuda.Text;
                fecha = cafecha.Text;
                propie = caspropietarios.Text;
                titulo = titule.Text;



                MessageBox.Show("Registrando Datos...!");

            }
            catch
            {

                MessageBox.Show("Revisar los datos insertados...");

            }
            finally
            {

                MessageBox.Show("Registro de activo Exitoso!");

            }

            dat.PROPIEDADES(catas, met, ubiccacion , cantidad, valori, valrf, fecha, deu, propie, titulo);



        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();

        }
    }
}
