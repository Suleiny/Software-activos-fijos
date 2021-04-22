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
    public partial class Form4 : Form
    {
        private Datos dat = new Datos();

        string marca, modelo, cantidad, precioI, precioA, propt, fechaI, año, codigo, matricula;

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {

                codigo = carcodigo.Text;

                MessageBox.Show("Eliminado datos de usuario...");
                Limpiar();
                DataG();

            }
            catch
            {
                MessageBox.Show("Revisar los datos");

            }
            finally
            {
                MessageBox.Show("Eliminado Correcto..!");
            }

            dat.DELETECAR(codigo);
                DataG();





        }

        private void carcodigo_Validated(object sender, EventArgs e)
        {

            if (carcodigo.Text.Trim() == "")
            {
                error.SetError(carcodigo, "Llenar el campo codigo");
                carcodigo.Focus();
            }
            else
            {
                error.Clear();

            }


        }

        private void carMarca_Validated(object sender, EventArgs e)
        {

            if (carMarca.Text.Trim() == "")
            {
                error.SetError(carMarca, "Llenar el campo marca");
                carMarca.Focus();
            }
            else
            {
                error.Clear();

            }





        }

        private void carmodelo_Validated(object sender, EventArgs e)
        {


            if (carmodelo.Text.Trim() == "")
            {
                error.SetError(carmodelo, "Llenar el campo modelo");
                carmodelo.Focus();
            }
            else
            {
                error.Clear();

            }





        }

        private void caryeard_TextChanged(object sender, EventArgs e)
        {
            if (caryeard.Text.Trim() == "")
            {
                error.SetError(caryeard ,"Llenar el campo año");
                caryeard.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void carcantidad_Validated(object sender, EventArgs e)
        {

            if (carcantidad.Text.Trim() == "")
            {
                error.SetError(carcantidad, "Llenar el campo cantdad");
                carcantidad.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void valor1_Validated(object sender, EventArgs e)
        {

            if (valor1.Text.Trim() == "")
            {
                error.SetError(valor1, "Llenar el campo precio inicial");
                valor1.Focus();
            }
            else
            {
                error.Clear();

            }




        }

        private void valor2_Validated(object sender, EventArgs e)
        {
            if (valor2.Text.Trim() == "")
            {
                error.SetError(valor2, "Llenar el campo precio actual");
                valor2.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void carfecha_Validated(object sender, EventArgs e)
        {

            if (carfecha.Text.Trim() == "")
            {
                error.SetError(carfecha, "Llenar el campo precio fecha ingreso");
                carfecha.Focus();
            }
            else
            {
                error.Clear();

            }


        }

        private void carpropietarios_Validated(object sender, EventArgs e)
        {
            if (carpropietarios.Text.Trim() == "")
            {
                error.SetError(carpropietarios, "Llenar el campo precio propietario");
                carpropietarios.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radiomatri_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void radiomatri_Click(object sender, EventArgs e)
        {
            matricula = BUSCUSER.Text;
            dataGridView1.DataSource = dat.BUSCARMATRICULA(matricula);

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            matricula = BUSCUSER.Text;
            dataGridView1.DataSource = dat.BUSCARMATRICULA(matricula);
        }

        private void VehiculoCodigo_Click(object sender, EventArgs e)
        {
            codigo = BUSCUSER.Text;
            dataGridView1.DataSource = dat.BUSCARVEHICODIGO(codigo);
        }

        private void BUSCUSER_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            try
            {
                codigo = carcodigo.Text;
                matricula = txtmatricula.Text;
                marca = carMarca.Text;
                modelo = carmodelo.Text;
                cantidad = carcantidad.Text;
                año = caryeard.Text;
                precioI = valor1.Text;
                precioA = valor2.Text;
                propt = carpropietarios.Text;
                fechaI = carfecha.Text;


                MessageBox.Show("Actalizando activo...");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados");

            }
            finally
            {

                MessageBox.Show("Actualizacion de activo Exitoso!!..");

            }

            dat.EDITCAR(codigo, marca, matricula, modelo, año, cantidad, precioI, precioA, fechaI, propt);
            DataG();



        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

            try
            {
                codigo = carcodigo.Text;
                matricula = txtmatricula.Text;
                marca = carMarca.Text;
                modelo = carmodelo.Text;
                cantidad = carcantidad.Text;
                año = caryeard.Text;
                precioI = valor1.Text;
                precioA = valor2.Text;
                propt = carpropietarios.Text;
                fechaI = carfecha.Text;


                MessageBox.Show("Registrando activo...");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados");

            }
            finally
            {

                MessageBox.Show("Registro de activo Exitoso!!..");

            }

            dat.CARROS(codigo, matricula, marca, modelo, año, cantidad, precioI, precioA, fechaI, propt);
            DataG();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
        
        public Form4()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
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




        public void DataG()
        {
            dataGridView1.DataSource = dat.DATOSCARROS();
        }








    }
}
