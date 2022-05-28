using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class DEditoriales
    {
        private int id_editorial;
        private string nombre;

        public int Id_editorial
        {
            get { return id_editorial; }
            set { id_editorial = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public DEditoriales()
        {

        }

        public DEditoriales(int id_editorial,string nombre)
        {
            this.Id_editorial = id_editorial;
            this.Nombre = nombre;

        }
        public string insertar(DEditoriales editorial)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
          
            //try
            //{
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insertar_editoriales";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 30;
                Pnombre.Value = Nombre;
                cmd.Parameters.Add(Pnombre);

                rpta=cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Inserto nada En Editoriales";



            //}
            //catch(Exception ex)
            //{
            //    rpta = ex.Message;
            //}
            return rpta;

        }
        public string editar(DEditoriales editorial)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            //try
            //{
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection=con;
                cmd.CommandText = "editar_editoriales";
                cmd.CommandType=CommandType.StoredProcedure;

                SqlParameter Pid_editorial = new SqlParameter();
                Pid_editorial.ParameterName = "@id_editorial";
                Pid_editorial.SqlDbType = SqlDbType.Int;
                Pid_editorial.Value = Id_editorial;
                cmd.Parameters.Add(Pid_editorial);

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 30;
                Pnombre.Value = Nombre;
                cmd.Parameters.Add(Pnombre);
                

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Edito Nada En Editoriales";


            //}catch(Exception ex)
            //{
            //    rpta = ex.Message;
            //}
            return rpta;
        }

        public string eliminar(DEditoriales editorial)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            //try
            //{
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "eliminar_editorial";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_editorial = new SqlParameter();
                Pid_editorial.ParameterName = "@id_editorial";
                Pid_editorial.SqlDbType = SqlDbType.Int;
                Pid_editorial.Value = Id_editorial;
                cmd.Parameters.Add(Pid_editorial);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Elimino Nada En Editoriales";

            //}catch(Exception ex)
            //{
            //    rpta = ex.Message;
            //}
            return rpta;
        }

        public DataTable mostrar()
        {
            DataTable dt = new DataTable("Editoriales");
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "mostrar_editoriales";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);

            return dt;
        }




    }
}
