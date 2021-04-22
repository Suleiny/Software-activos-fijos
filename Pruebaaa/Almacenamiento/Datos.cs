using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Pruebaaa
{

    //CLASE PARA LA CONEXION DE LA BASE DE DATOS
    class Datos
    {
       


      

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-GAB0UPU;Initial Catalog=Afijos;Integrated Security=True");

        SqlCommand comandos;




    



















        //LOGUEO DE USUARIOS NUEVOS //

        public void Register(string nombre, string user, string clave)
        {
            Conexion.Open();

            string datocomand = $"INSERT INTO LOGI VALUES ('{nombre}', '{user}','{clave}')";
            comandos = new SqlCommand(datocomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();

        }


        ////////// REGISTRO DE LOS USUARIOS //////
        ///

       

        public void USUARIOS(string nombre, string apellido, string cedula, string genero, string  fechan, string direccion, string email, string celular, string telefono, string acad, string estd, string trabajo)
        {

            Conexion.Open();
            string datocomand = $"INSERT INTO USUARIO VALUES('{nombre}','{apellido}','{cedula}','{genero}','{fechan}','{direccion}','{email}','{celular}','{telefono}','{acad}','{estd}','{trabajo}')";
            comandos = new SqlCommand(datocomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();


        }



        public void EMPLEADOS( string nom, string apell,string cedula, string fecha2, string fecha1, string sueldo, string cel, string tel, string email, string direc, string ocup,string estdo)
        {

            Conexion.Open();
            string datcomand= $"INSERT INTO PERSONAL VALUES ('{nom}','{apell}','{cedula}','{fecha1}','{fecha2}','{cel}','{tel}','{email}','{direc}','{ocup}','{estdo}','{sueldo}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }








        ////// METODO REGISTROS DE CARROS

        public void CARROS(string codigo, string matri , string marca,string modelo, string año, string cantidad, string precioI, string precioA, string fechaI, string propt)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO CARROS VALUES ('{codigo}','{matri}','{marca}','{modelo}','{año}','{cantidad}','{precioI}','{precioA}','{fechaI}','{propt}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }


        //REGISTRO DE LOS  CASA //
        public void PROPIEDADES( string catas, string met, string ubiccacion , string cantidad, string valori, string valrf, string fecha , string deu, string propie, string titulo)
        {

            Conexion.Open();
            string datcomand = $"INSERT INTO CASAS VALUES('{catas}','{met}','{ubiccacion}','{cantidad}','{valori}','{valrf}','{fecha}','{deu}','{propie}','{titulo}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }




     //REGISTRO DE LAS EDIFICACIONES //

        public void  EDIFICACION (string catast, string metr, string ubic, string cantid, string val1, string val2, string fech, string deud, string due, string titl)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO EDIFICACION VALUES('{catast}','{metr}','{ubic}','{cantid}','{val1}','{val2}','{fech}','{deud}','{due}','{titl}')";
             comandos= new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();



        }


        //REGISTRO DE MAQUINARIAS

        public void MAQUINARIAS(string coig, string model, string marc, string year, string cand, string vl1, string vl2, string pro, string Fi)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO MAQUINARIAS VALUES('{coig}','{model}','{marc}','{year}','{cand}','{vl1}','{vl2}','{pro}','{Fi}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();



        }





        /////////////////////////////////METODOS PARA ACTUALIZAR LOS DATOS////////////////////////////////////////



        public void EDITUSUARIOS(string nombre, string apellido, string cedula, string genero, string fechan, string direccion, string email, string celular, string telefono, string acad, string estd, string trabajo)
        {

            Conexion.Open();
            string datocomand = $"update USUARIO set nombre_usuario ='{nombre}',apellido_usuario ='{apellido}',sexo ='{genero}',fecha_nacimiento ='{fechan}',direccion_usuario ='{direccion}',email_usuario='{email}',celular_usuario ='{celular}',telefono2_usuario ='{telefono}',academico_usuario ='{acad}', estado_usuario= '{estd}', ocupacion_usuario= '{trabajo}' where cedula_usuario = '{cedula}'";
            comandos = new SqlCommand(datocomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();


        }
      



        public void EDITCAR(string codigo,  string matri,  string marca,string modelo, string año, string cantidad, string precioI, string precioA, string fechaI, string propt)
        {
            Conexion.Open();
            string datcomand = $"update CARROS set  Codigo ='{codigo}', Marca= '{marca}', Modelo ='{modelo}', Año_Ingreso = '{año}',Cantida  = '{cantidad}', Valor_Inicial ='{precioI}', Valor_Final ='{precioA}', Fecha_ingreso ='{fechaI}', propietario ='{propt}' where Matricula] = '{matri}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }


   
        public void EDITCASA(string catas, string met, string ubiccacion, string cantidad, string valori, string valrf, string fecha, string deu, string propie, string titulo)
        {

            Conexion.Open();
            string datcomand = $"update CARROS metros_casa ='{met}',ubicacion_casa ='{ubiccacion}',cantidad_casa = '{cantidad}', ValorInicial ='{valori}', ValorFinal= '{valrf}', fecha_ingreso ='{fecha}', Deuda_casa ='{deu}',propietario_casa ='{propie}', TitPr_activo_activo= '{titulo} where set catastro_casa =('{catas}'')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }

  
	

        public void EDITEDIFICACION(string catast, string metr, string ubic, string cantid, string val1, string val2, string fech, string deud, string due, string titl)
        {
            Conexion.Open();

            string datcomand = $"update CARROS metros_E ='{metr}',ubicacion_E ='{ubic}',cantidad_E] = '{cantid}', ValorInicial_E ='{val1}', ValorFinal_E = '{val2}', fechai_E ='{fech}', Deuda_E ='{deud}',propietario_E ='{due}', TitPr_activo_E= '{titl} where set catastro_casa =('{catast}'')";
              
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }






        /////////////////////////////////METODOS PARA ELIMINAR LOS DATOS////////////////////////////////////////


        public void DELETEUSER( string cedula)
        {
            Conexion.Open();

            string datcomand = $"DELETE FROM USUARIO WHERE cedula_usuario ='{cedula}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();




        }

        public void DELETEEMPL( string cedula)
        {
            Conexion.Open();

            string datcomand = $"DELETE FROM  PERSONAL WHERE cedula ='{cedula}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();

        }


        public void DELETECAR(string codigo)
        {
            Conexion.Open();

            string datcomand = $"DELETE FROM  CARROS where Codigo='{codigo}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();

        }

        public void DELETECASA(string catastroc)
        {
            Conexion.Open();

            string datcomand = $"DELETE FROM  CARROS WHERE catastro_casa ='{catastroc}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();

        }


        public void DELETEEDIFICACION( string catastroe)
        {
            Conexion.Open();
            string datcomand = $"DELETE FROM  EDIFICACION WHERE catastro_E ='{catastroe}'";
            comandos = new SqlCommand(datcomand, Conexion);;
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }


        public void DELETEMAQUINA(string Codigo)
        {
            Conexion.Open();
            string datcomand = $"DELETE FROM  MAQUINARIAS WHERE codigo_pc ='{Codigo}'";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }











        ///////////////////////////// METODO PARA BUSCAR DATOS///////////////////////////////////////////////////
        ///
      

        public DataTable BUSCARMATRICULA(string matricula)
        {

           Conexion.Open();
            string datcomand = $"Select* from CARROS where Matricula ='{matricula}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }



        public DataTable MAQMODELO(string modelo)
        {
            Conexion.Open();
            string datcomand = $"Select * from MAQUINARIA where modelo '{modelo}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }


        public DataTable BUSCARUSER(string nombre)
        {

            Conexion.Open();
            string datcomand = $"select* from USUARIO where nombre_usuario ='{nombre}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }



        public DataTable BUSCARUSERC(string cedula)
        {

            Conexion.Open();
            string datcomand = $"select* from USUARIO where cedula_usuario='{cedula}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }





        public DataTable BUSCARMAQM(string marca)
        {

            Conexion.Open();
            string datcomand = $"select* from MAQUINARIAS where marca ='{marca}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }

        public DataTable BUSCARMAQC(string codigo)
        {

            Conexion.Open();
            string datcomand = $"select* from MAQUINARIAS where codigo ='{codigo}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }

        public DataTable BUSCARMAQMO(string model)
        {

            Conexion.Open();
            string datcomand = $"select* from MAQUINARIAS where modelo ='{model}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }

        public DataTable BUSCARVEHICODIGO(string codigo)
        {

            Conexion.Open();
            string datcomand = $"select* from CARROS where modelo ='{codigo}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }

        public DataTable BUSCARTERRENO(string cat)
        {

            Conexion.Open();
            string datcomand = $"Select*from EDIFICACION where catastro_E ='{cat}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }



        public DataTable PROPIETARIOE(string propietario)
        {

            Conexion.Open();
            string datcomand = $"Select*from EDIFICACION where propietario_E ='{propietario}'";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);
            Conexion.Close();
            return table;
        }





        ///////////METODO PARA LLENAR LA TABLA CON LOS DATOS



        public DataTable DATOSEMPLEADOS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM PERSONAL";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }




        public DataTable DATOSUSUARIOS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM USUARIO";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }



        public DataTable DATOSCARROS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM CARROS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        } 



        public DataTable DATOSCASAS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM CASAS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }


        public DataTable DATOSEDIFCIO()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM EDIFICACION";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }

        public DataTable DATOSMAQUINARIAS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM MAQUINARIAS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();

            return table;
        }



       //////// // METODOS PARA BUSQUEDAD DE LOS DATOS /////////
       
        public void BEMPLEADOS(string cedula)
        {

        }




        public void filtro()
        {
            


           



        }





    }

}









