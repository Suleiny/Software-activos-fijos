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
    public partial class Seleccion : Form
    {


        private Datos dat = new Datos();
        string Vehiculo;
        public Seleccion()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void casa_Click(object sender, EventArgs e)
        {
            Form formulario = new Propiedad5();
            formulario.Show();

        }

        private void carros_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
         


        }

        private void maquinas_Click(object sender, EventArgs e)
        {
            Form formulario = new Maquinarias();
            formulario.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Edificio();
            formulario.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }
    }
}
