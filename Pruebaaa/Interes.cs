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
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }

        private void guna1_MouseMove(object sender, MouseEventArgs e)
        {
            lab1.Visible = true;
        }

        private void guna2_MouseMove(object sender, MouseEventArgs e)
        {
            lab2.Visible = true;
        }

        private void guna3_MouseMove(object sender, MouseEventArgs e)
        {
            lab3.Visible = true;
        }

        private void guna4_MouseMove(object sender, MouseEventArgs e)
        {
            lab4.Visible = true;
        }

        private void guna5_MouseMove(object sender, MouseEventArgs e)
        {
            lab5.Visible = true;
        }

        private void gunaRD_MouseMove(object sender, MouseEventArgs e)
        {
            rep.Visible = true;
        }

        private void guna911_MouseMove(object sender, MouseEventArgs e)
        {
            emer.Visible = true;
        }

        private void guna311_MouseMove(object sender, MouseEventArgs e)
        {
            ciud.Visible = true;
        }

        private void gunadigt_MouseMove(object sender, MouseEventArgs e)
        {
            digital.Visible=true;
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Interes_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();

        }

        private void guna5_Click(object sender, EventArgs e)
        {

        }
    }
}
