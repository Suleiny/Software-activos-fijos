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
    public partial class User : Form
    {

       private  Datos dat = new Datos();

        string nombre, apellido, genero, acad,  celular, telefono, direccion, fechan,cedula, email, trabajo ,estd;

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                cedula = EmpCedula.Text;
          



                MessageBox.Show("Eliminado datos de usuario...");
                Limpiar();

            }
            catch
            {
                MessageBox.Show("Revisar los datos");

            }
            finally
            {
                MessageBox.Show("Eliminado Correcto..!");
            }

            dat.DELETEUSER( cedula);

            DataG();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = empnombre.Text;
                apellido = empapellido.Text;
                cedula = EmpCedula.Text;
                genero = sexo.Text;
                fechan = guna2TextBox3.Text;
                direccion = empldireccion.Text;
                email = empGmail.Text;
                celular = empltelf2.Text;
                telefono = emptelef.Text;
                acad = academico.Text;
                estd = estad.Text;
                trabajo = ocupacion.Text;



                MessageBox.Show("Actualizando datos de usuarios...");
                Limpiar();

            }
            catch
            {
                MessageBox.Show("Revisar los datos");


            }
            finally
            {
                MessageBox.Show("Actualizacion Exitosa...");

            }

            dat.EDITUSUARIOS(nombre, apellido, genero, cedula, celular, telefono, fechan, direccion, email, estd, trabajo, acad);

            DataG();


        }






        /*BOTON DE REGISTRAR LOS DATOS*/
        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = empnombre.Text;
                apellido = empapellido.Text;
                cedula = EmpCedula.Text;
                genero = sexo.Text;
                fechan = guna2TextBox3.Text;
                direccion = empldireccion.Text;
                email = empGmail.Text;
                celular = empltelf2.Text;
                telefono = emptelef.Text;
                acad = academico.Text;
                estd = estad.Text;
                trabajo = ocupacion.Text;



                MessageBox.Show("Registrando datos de usuarios...");
                Limpiar();

            }
            catch
            {
                MessageBox.Show("Revisar los datos");


            }
            finally
            {
                MessageBox.Show("Registro Exitoso...");

            }

            dat.USUARIOS(nombre, apellido, genero, cedula, celular, telefono, fechan, direccion, email, estd, trabajo, acad);

            DataG();
        }


        /*VALIDACION DE LOS CAMPOS DE INSERCION DE DATOS*/
        private void empnombre_Validated(object sender, EventArgs e)
        {
            if (empnombre.Text.Trim()=="")
            {
                error.SetError(empnombre, "Llenar el campo nombre");
                empnombre.Focus();
            }
            else
            {
                error.Clear();

            }
                
              

        }

        private void empapellido_Validated(object sender, EventArgs e)
        {

            if (empapellido.Text.Trim() == "")
            {
                error.SetError(empapellido, "Llenar el campo apellido");
                empapellido.Focus();
            }
            else
            {
                error.Clear();

            }



        }

        private void EmpCedula_Validated(object sender, EventArgs e)
        {


            if (EmpCedula.Text.Trim() == "")
            {
                error.SetError(EmpCedula, "Llenar el campo cedula");
                EmpCedula.Focus();
            }
            else
            {
                error.Clear();

            }



        }

        private void sexo_Validated(object sender, EventArgs e)
        {

            if (sexo.Text.Trim() == "")
            {
                error.SetError(sexo, "Llenar el campo sexo");
                sexo.Focus();
            }
            else
            {
                error.Clear();

            }






        }

        private void guna2TextBox3_Validated(object sender, EventArgs e)
        {

            if (guna2TextBox3.Text.Trim() == "")
            {
                error.SetError(guna2TextBox3, "Llenar el campo fecha");
                guna2TextBox3.Focus();
            }
            else
            {
                error.Clear();

            }




        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void empGmail_Validated(object sender, EventArgs e)
        {


            if (empGmail.Text.Trim() == "")
            {
                error.SetError(empGmail, "Llenar el campo Email");
                empGmail.Focus();
            }
            else
            {
                error.Clear();

            }




        }

        private void emptelef_Validated(object sender, EventArgs e)
        {

            if (emptelef.Text.Trim() == "")
            {
                error.SetError(emptelef, "Llenar el campo Celular");
                emptelef.Focus();
            }
            else
            {
                error.Clear();

            }


        }

        private void empltelf2_Validated(object sender, EventArgs e)
        {

            if (empltelf2.Text.Trim() == "")
            {
                error.SetError(empltelf2, "Llenar el campo Telefono");
                empltelf2.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void empldireccion_Validated(object sender, EventArgs e)
        {


            if (empldireccion.Text.Trim() == "")
            {
                error.SetError(empldireccion, "Llenar el campo direccion");
                empldireccion.Focus();
            }
            else
            {
                error.Clear();

            }


        }

        private void estad_Validated(object sender, EventArgs e)
        {
            if (estad.Text.Trim() == "")
            {
                error.SetError(estad, "Llenar el campo estado");
                estad.Focus();
            }
            else
            {
                error.Clear();

            }

        }

        private void academico_Validated(object sender, EventArgs e)
        {
            if (academico.Text.Trim() == "")
            {
                error.SetError(academico, "Llenar el campo academico");
                estad.Focus();
            }
            else
            {
                error.Clear();

            }


        }

        private void ocupacion_Validated(object sender, EventArgs e)
        {
            if (ocupacion.Text.Trim() == "")
            {
                error.SetError(ocupacion, "Llenar el campo ocupacion");
                ocupacion.Focus();
            }
            else
            {
                error.Clear();

            }




        }

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-GAB0UPU;Initial Catalog=Afijos;Integrated Security=True");


        private void BUSCUSER_KeyUp(object sender, KeyEventArgs e)
        {

          
            Conexion.Open();

            SqlCommand command = Conexion.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT*FROM USUARIO WHERE nombre_usuario  LIKE  ('" + BUSCUSER.Text + "%' )";
            command.ExecuteNonQuery();

            DataTable table = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(command);
            adap.Fill(table);
            dataGridView1.DataSource = adap;

            Conexion.Close();


            dataGridView1.DataSource = dat.DATOSUSUARIOS();


        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            



        }

        private void BUSCUSER_TextChanged(object sender, EventArgs e)
        {
             










        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        public User()
        {
            InitializeComponent();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

           



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
            dataGridView1.DataSource = dat.DATOSUSUARIOS();
        }

    }
}
