using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
   public  class Dautores
    {
          private int _id_autor;
        private string _nombre;
        private string _apellido;
        private string _mail;

       

            public int Id_autor
             {
            get { return _id_autor; }
            set { _id_autor = value; }
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
            public string Mail
            {
            get { return _mail; }
            set { _mail = value; }
            }
            public Dautores()
            {

            }

        public Dautores(int id_autor,string nombre,string apellido,string mail)
            {
                this.Id_autor = id_autor;
                this.Nombre = Nombre;
                this.Apellido = apellido;
                this.Mail = mail;

            }

        public string insertar(Dautores autor)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insertar_autores";
                cmd.CommandType = CommandType.StoredProcedure;



                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 30;
                Pnombre.Value = Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Papellido = new SqlParameter();
                Papellido.ParameterName = "@apellido";
                Papellido.SqlDbType = SqlDbType.VarChar;
                Papellido.Size = 50;
                Papellido.Value = Apellido;
                cmd.Parameters.Add(Papellido);

                SqlParameter Parmail = new SqlParameter();
                Parmail.ParameterName = "@mail";
                Parmail.SqlDbType = SqlDbType.VarChar;
                Parmail.Size = 50;
                Parmail.Value = autor.Mail;
                cmd.Parameters.Add(Parmail);


                rpta = cmd.ExecuteNonQuery() ==1?"OK":"No Se Inserto el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rpta;
        }
        public string editar(Dautores autor)
        {
            SqlConnection con = new SqlConnection();
            string rpta="";
            try
            {
                con.ConnectionString=Conexion.cn;
                con.Open();
                SqlCommand cmd=new SqlCommand();
                cmd.Connection=con;
                cmd.CommandText="editar_autores";
                cmd.CommandType=CommandType.StoredProcedure;

                SqlParameter Pid_autor=new SqlParameter();
                Pid_autor.ParameterName="@id_autor";
                Pid_autor.SqlDbType=SqlDbType.Int;
                Pid_autor.Value=Id_autor;
                cmd.Parameters.Add(Pid_autor);

                SqlParameter Pnombre=new SqlParameter();
                Pnombre.ParameterName="@nombre";
                Pnombre.SqlDbType=SqlDbType.VarChar;
                Pnombre.Value=Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Papellido=new SqlParameter();
                Papellido.ParameterName="@apellido";
                Papellido.SqlDbType=SqlDbType.VarChar;
                Papellido.Value=Apellido;
                cmd.Parameters.Add(Papellido);

                SqlParameter Pmail = new SqlParameter();
                Pmail.ParameterName = "@mail";
                Pmail.SqlDbType = SqlDbType.VarChar;
                Pmail.Size = 50;
                Pmail.Value = Mail;
                cmd.Parameters.Add(Pmail);

               rpta= cmd.ExecuteNonQuery()==1?"OK":"No se Edito Nada";

            }
            catch(Exception ex)
            {
                rpta=ex.Message;
            }
            finally
            {
                if(con.State==ConnectionState.Open) con.Close();
            }
            return rpta;

        } 

        public string eliminar(Dautores autor)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "eliminar_autores";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_autor = new SqlParameter();
                Pid_autor.ParameterName = "@id_autor";
                Pid_autor.SqlDbType = SqlDbType.Int;
                Pid_autor.Value = Id_autor;
                cmd.Parameters.Add(Pid_autor);


                rpta = cmd.ExecuteNonQuery()==1?"OK":"No Se Elimino Nada";



            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rpta;
        }

        public DataTable mostrar()
        {
            DataTable dt = new DataTable("Autores");
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "mostrar_autores";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);

            return dt;
        }


    }
    }

