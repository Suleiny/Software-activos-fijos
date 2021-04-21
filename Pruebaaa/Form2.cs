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
    public partial class Formbienveida : Form
    {
        public Formbienveida()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Form formulario = new Home();
            formulario.Show();
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labnombE_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            telefono.Visible = true;
        }

       

        private void guna2CirclePictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Lemail.Visible = true;
        }

        private void guna2CirclePictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            ubicacion.Visible = true;
        }

        private void guna2CirclePictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            facebook.Visible = true;
        }

        private void guna2CirclePictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            instagram.Visible = true;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void boton4_Click(object sender, EventArgs e)
        {
            Form formulario = new Usuario();
            formulario.Show();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Form formulario = new Seleccion();
            formulario.Show();
        }

        private void boton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Buscar();
            formulario.Show();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            Form formulario = new User();
            formulario.Show();
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            Form formulario = new Reportes();
            formulario.Show();
        }

        private void botn7_Click(object sender, EventArgs e)
        {
            Form formulario = new ayuda();
            formulario.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void boton5_Click(object sender, EventArgs e)
        {
            Form formulario = new Interes();
            formulario.Show();
        }

        private void gunaCirclePictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            hola.Visible = true;
        }

        private void gunaCirclePictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
        }

        private void gunaCirclePictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void gunaCirclePictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }

        private void gunaCirclePictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Visible = true;
        }

        private void Formbienveida_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbfecha.Text = DateTime.Now.ToString("dddd:MMM:yyy");





        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
