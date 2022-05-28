using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dalumnos
    {
        private int _id_alumno;
        private string _nombre;
        private string _apellido;
        private string _dni;
       private string _telefono;
        private string _direccion;
        private string _mail;

       

        public int Id_alumno
        {
            get { return _id_alumno; }
            set { _id_alumno = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        //constructor vacio
        public Dalumnos()
        {

        }

        //constructor con parametros
        public Dalumnos(int id_alumno, string nombre, string apellido, string dni,string telefono, string direccion, string mail)
        {
            this.Id_alumno = id_alumno;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
           this.Telefono = telefono;
            this.Direccion = direccion;
            this.Mail = mail;

        
        }

        //metodo insertar

        public string insertar(Dalumnos alumno)
        {
            string rpta="";
            SqlConnection sqlcon=new SqlConnection();
            try
            {   
                //codigo
                sqlcon.ConnectionString=Conexion.cn;
                sqlcon.Open();
                //establecer comando
                SqlCommand sqlcmd=new SqlCommand();
                sqlcmd.Connection=sqlcon;
                sqlcmd.CommandText="insertar_alumnos";
                sqlcmd.CommandType=CommandType.StoredProcedure;

                SqlParameter parid_alumno = new SqlParameter();
                parid_alumno.ParameterName = "@id_alumno";
                parid_alumno.SqlDbType = SqlDbType.Int;
                parid_alumno.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parid_alumno);

                SqlParameter Parnombre=new SqlParameter();
                Parnombre.ParameterName="@nombre";
                Parnombre.SqlDbType=SqlDbType.VarChar;
                Parnombre.Size=30;
                Parnombre.Value=alumno.Nombre;
                sqlcmd.Parameters.Add(Parnombre);

                SqlParameter Parapellido=new SqlParameter();
                Parapellido.ParameterName="@apellido";
                Parapellido.SqlDbType=SqlDbType.VarChar;
                Parapellido.Size=40;
                Parapellido.Value=alumno.Apellido;
                sqlcmd.Parameters.Add(Parapellido);

                SqlParameter Pardni=new SqlParameter();
                Pardni.ParameterName="@dni";
                Pardni.SqlDbType=SqlDbType.VarChar;
                Pardni.Size=8;
                Pardni.Value=alumno.Dni;
                sqlcmd.Parameters.Add(Pardni);

                SqlParameter Partel = new SqlParameter();
                Partel.ParameterName = "@telefono";
                Partel.SqlDbType = SqlDbType.VarChar;
                Partel.Size = 10;
                Partel.Value = alumno.Telefono;
                sqlcmd.Parameters.Add(Partel);

                 SqlParameter Pardireccion=new SqlParameter();
                Pardireccion.ParameterName="@direccion";
                Pardireccion.SqlDbType=SqlDbType.VarChar;
                Pardireccion.Size=40;
                Pardireccion.Value=alumno.Direccion;
                sqlcmd.Parameters.Add(Pardireccion);

                  SqlParameter Parmail=new SqlParameter();
                Parmail.ParameterName="@mail";
                Parmail.SqlDbType=SqlDbType.VarChar;
                Parmail.Size=30;
                Parmail.Value=alumno.Mail;
                sqlcmd.Parameters.Add(Parmail);
                //ejecutamos el comando

                rpta=sqlcmd.ExecuteNonQuery()==1?"OK":"No se Inserto El Registro";

                

            }
            catch(Exception ex)
            {
                rpta=ex.Message;
            }
            finally
            {
                if(sqlcon.State==ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }
        //metodo editar
        public string editar(Dalumnos alumno)
        {
             string rpta="";
            SqlConnection sqlcon=new SqlConnection();
            try
            {   
                //codigo
                sqlcon.ConnectionString=Conexion.cn;
                sqlcon.Open();
                //establecer comando
                SqlCommand sqlcmd=new SqlCommand();
                sqlcmd.Connection=sqlcon;
                sqlcmd.CommandText="editar_alumnos";
                sqlcmd.CommandType=CommandType.StoredProcedure;

                SqlParameter parid_alumno=new SqlParameter();
                parid_alumno.ParameterName="@id_alumno";
                parid_alumno.SqlDbType=SqlDbType.Int;
                parid_alumno.Value=alumno.Id_alumno;
                sqlcmd.Parameters.Add(parid_alumno);

                SqlParameter Parnombre=new SqlParameter();
                Parnombre.ParameterName="@nombre";
                Parnombre.SqlDbType=SqlDbType.VarChar;
                Parnombre.Size=30;
                Parnombre.Value=alumno.Nombre;
                sqlcmd.Parameters.Add(Parnombre);

                SqlParameter Parapellido=new SqlParameter();
                Parapellido.ParameterName="@apellido";
                Parapellido.SqlDbType=SqlDbType.VarChar;
                Parapellido.Size=40;
                Parapellido.Value=alumno.Apellido;
                sqlcmd.Parameters.Add(Parapellido);

                SqlParameter Pardni=new SqlParameter();
                Pardni.ParameterName="@dni";
                Pardni.SqlDbType=SqlDbType.VarChar;
                Pardni.Size=8;
                Pardni.Value=alumno.Dni;
                sqlcmd.Parameters.Add(Pardni);

                SqlParameter Partel=new SqlParameter();
                Partel.ParameterName="@telefono";
                Partel.SqlDbType=SqlDbType.VarChar;
                Partel.Size=10;
                Partel.Value=alumno.Telefono;
                sqlcmd.Parameters.Add(Partel);

                 SqlParameter Pardireccion=new SqlParameter();
                Pardireccion.ParameterName="@direccion";
                Pardireccion.SqlDbType=SqlDbType.VarChar;
                Pardireccion.Size=40;
                Pardireccion.Value=alumno.Direccion;
                sqlcmd.Parameters.Add(Pardireccion);

                  SqlParameter Parmail=new SqlParameter();
                Parmail.ParameterName="@mail";
                Parmail.SqlDbType=SqlDbType.VarChar;
                Parmail.Size=30;
                Parmail.Value=alumno.Mail;
                sqlcmd.Parameters.Add(Parmail);
                //ejecutamos el comando

                rpta=sqlcmd.ExecuteNonQuery()==1?"OK":"No se Actualizo El Registro";

                

            }
            catch(Exception ex)
            {
                rpta=ex.Message;
            }
            finally
            {
                if(sqlcon.State==ConnectionState.Open) sqlcon.Close();
            }
            return rpta;

        }
        //metodo eliminar
        public string eliminar(Dalumnos alumnos)
        {
             string rpta="";
            SqlConnection sqlcon=new SqlConnection();
            try
            {   
                //codigo
                sqlcon.ConnectionString=Conexion.cn;
                sqlcon.Open();
                //establecer comando
                SqlCommand sqlcmd=new SqlCommand();
                sqlcmd.Connection=sqlcon;
                sqlcmd.CommandText="eliminar_alumnos";
                sqlcmd.CommandType=CommandType.StoredProcedure;

                SqlParameter parid_alumno=new SqlParameter();
                parid_alumno.ParameterName="@id_alumno";
                parid_alumno.SqlDbType=SqlDbType.Int;
                parid_alumno.Value=alumnos.Id_alumno;
                sqlcmd.Parameters.Add(parid_alumno);
            
                //ejecutamos el comando

                rpta=sqlcmd.ExecuteNonQuery()==1?"OK":"No se Elimino El Registro";

                

            }
            catch(Exception ex)
            {
                rpta=ex.Message;
            }
            finally
            {
                if(sqlcon.State==ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }
        //metodo mostrar
        public DataTable mostar() 
        {
            DataTable dt = new DataTable("Alumnos");
            SqlConnection sqlcon = new SqlConnection();
            
                sqlcon.ConnectionString = Conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "mostrar_alumnos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                sqlda.Fill(dt);


          
           
            return dt;

        
        }
        public DataTable Deuda(int id_alumno)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Verificar_deuda";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id_alumno;
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            return dt;


        }




    }
}
