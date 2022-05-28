using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dlibro
    {
        private int id_libro;
        private int id_editor;
        private int id_editorial;
        private int id_genero;
        private string nombre;
        private DateTime año_publicacion;
        private string estado;



        public int Id_libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }
        public int Id_editor
        {
            get { return id_editor; }
            set { id_editor = value; }
        }
        public int Id_editorial
        {
            get { return id_editorial; }
            set { id_editorial = value; }
        }
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
        public DateTime Año_publicacion
        {
            get { return año_publicacion; }
            set { año_publicacion = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Dlibro()
        {
            //constructor vacio
        }

        public Dlibro(int id_libro,int id_editor,int id_genero,int id_editorial,string nombre,DateTime año_publicacion,string estado)
        {
            this.Id_libro = id_libro;
            this.Id_editor = id_editor;
            this.Id_editorial = id_editorial;
            this.Nombre = nombre;
            this.Año_publicacion = año_publicacion;
            this.Estado = estado;

        }

        public string insertar(Dlibro libro)
        {
            string rpta="";

            SqlConnection con = new SqlConnection();
            //try
            //{
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insertar_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_editor = new SqlParameter();
                Pid_editor.ParameterName = "@id_editor";
                Pid_editor.SqlDbType = SqlDbType.Int;
                Pid_editor.Value = libro.Id_editor;
                cmd.Parameters.Add(Pid_editor);

                SqlParameter Pid_genero = new SqlParameter();
                Pid_genero.ParameterName = "@id_genero";
                Pid_genero.SqlDbType = SqlDbType.Int;
                Pid_genero.Value = libro.Id_genero;
                cmd.Parameters.Add(Pid_genero);

                SqlParameter Pid_editorial = new SqlParameter();
                Pid_editorial.ParameterName = "@id_editorial";
                Pid_editorial.SqlDbType = SqlDbType.Int;
                Pid_editorial.Value = libro.Id_editorial;
                cmd.Parameters.Add(Pid_editorial);

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 40;
                Pnombre.Value = libro.Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Paño_pub = new SqlParameter();
                Paño_pub.ParameterName = "@año";
                Paño_pub.SqlDbType = SqlDbType.Date;
                Paño_pub.Value = libro.Año_publicacion;
                cmd.Parameters.Add(Paño_pub);

                //SqlParameter Pestado = new SqlParameter();
                //Pestado.ParameterName = "@estado";
                //Pestado.SqlDbType = SqlDbType.VarChar;
                //Pestado.Size = 30;
                //Pestado.Value = libro.Estado;
                //cmd.Parameters.Add(Pestado);


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Inserto Ningun Libro";



            //}catch(Exception ex)
            //{
            //    rpta = ex.Message;
                
                
            //}finally
            //{
            //    if (con.State == ConnectionState.Open) con.Close();
            //}
            return rpta;



        }

        public string editar(Dlibro libro)
        {
            string rpta = "";

            SqlConnection con = new SqlConnection();
            //try
            //{
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "editar_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_libro = new SqlParameter();
                Pid_libro.ParameterName = "@id_libro";
                Pid_libro.SqlDbType = SqlDbType.Int;
                Pid_libro.Value = libro.Id_libro;
                cmd.Parameters.Add(Pid_libro);

                SqlParameter Pid_editor = new SqlParameter();
                Pid_editor.ParameterName = "@id_editor";
                Pid_editor.SqlDbType = SqlDbType.Int;
                Pid_editor.Value = libro.Id_editor;
                cmd.Parameters.Add(Pid_editor);

                SqlParameter Pid_genero = new SqlParameter();
                Pid_genero.ParameterName = "@id_genero";
                Pid_genero.SqlDbType = SqlDbType.Int;
                Pid_genero.Value = libro.Id_genero;
                cmd.Parameters.Add(Pid_genero);

                SqlParameter Pid_editorial = new SqlParameter();
                Pid_editorial.ParameterName = "@id_editorial";
                Pid_editorial.SqlDbType = SqlDbType.Int;
                Pid_editorial.Value = libro.Id_editorial;
                cmd.Parameters.Add(Pid_editorial);

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 40;
                Pnombre.Value = libro.Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Paño_pub = new SqlParameter();
                Paño_pub.ParameterName = "@año";
                Paño_pub.SqlDbType = SqlDbType.Date;
                Paño_pub.Value = libro.Año_publicacion;
                cmd.Parameters.Add(Paño_pub);

             


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Actualizo Ningun Libro";



            //}
            //catch (Exception ex)
            //{
            //    rpta = ex.Message;
            //}
            //finally
            //{
            //    if (con.State == ConnectionState.Open) con.Close();
            //}
            return rpta;




        }

        public string eliminar(Dlibro libro)
        {
            string rpta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "eliminar_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_libro = new SqlParameter();
                Pid_libro.ParameterName = "@id_libro";
                Pid_libro.SqlDbType = SqlDbType.Int;
                Pid_libro.Value = libro.Id_libro;
                cmd.Parameters.Add(Pid_libro);

                


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Elimino Ningun Libro";



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

        public DataTable mostar()
        {
            DataTable dt = new DataTable("Libros");
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "mostrar_libro";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);

            return dt;


        }



    }
}
