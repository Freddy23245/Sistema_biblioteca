using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
   public class Dgenero
    {
       private int id_genero;
        private string nombre;


  public int Id_genero
        {
            get { return id_genero; }
            set { id_genero = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Dgenero()
        {

        }

       public Dgenero(int id_genero,string nombre)
        {
            this.Id_genero = id_genero;
            this.Nombre = nombre;

        }

       public string insertar(Dgenero genero)
       {
           string rpta = "";
           SqlConnection con = new SqlConnection();

           try
           {
               con.ConnectionString = Conexion.cn;
               con.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = "insertar_genero";
               cmd.CommandType = CommandType.StoredProcedure;

               SqlParameter Pnombre = new SqlParameter();
               Pnombre.ParameterName = "@nombre";
               Pnombre.SqlDbType = SqlDbType.VarChar;
               Pnombre.Size = 30;
               Pnombre.Value = Nombre;
               cmd.Parameters.Add(Pnombre);

               rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se Inserto Nada En Genero";



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

       public string editar(Dgenero genero)
       {
           string rpta = "";
               SqlConnection con = new SqlConnection();
           try
           {
               
               con.ConnectionString = Conexion.cn;
               con.Open();

               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = "editar_genero";
               cmd.CommandType = CommandType.StoredProcedure;

               SqlParameter Pid_genero = new SqlParameter();
               Pid_genero.ParameterName = "@id_genero";
               Pid_genero.SqlDbType = SqlDbType.Int;
               Pid_genero.Value = Id_genero;
               cmd.Parameters.Add(Pid_genero);

               SqlParameter Pnombre = new SqlParameter();
               Pnombre.ParameterName = "@nombre";
               Pnombre.SqlDbType = SqlDbType.VarChar;
               Pnombre.Size = 30;
               Pnombre.Value = Nombre;
               cmd.Parameters.Add(Pnombre);

               rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se Edito Nada En Genero";



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
       public string eliminar(Dgenero genenero)
       {
           string rpta="";
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.cn;
               con.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = "eliminar_genero";
               cmd.CommandType = CommandType.StoredProcedure;

               SqlParameter Pid_genero = new SqlParameter();
               Pid_genero.ParameterName = "@id_genero";
               Pid_genero.SqlDbType = SqlDbType.Int;
               Pid_genero.Value = Id_genero;
               cmd.Parameters.Add(Pid_genero);

               rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Elimino Nada En Genero";



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
       public DataTable mostrar()
       {
           DataTable dt = new DataTable("Generos");
           SqlConnection sqlcon = new SqlConnection();

           sqlcon.ConnectionString = Conexion.cn;
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.Connection = sqlcon;
           sqlcmd.CommandText = "mostrar_genero";
           sqlcmd.CommandType = CommandType.StoredProcedure;

           SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
           sqlda.Fill(dt);

           return dt;
       }


    }
}
