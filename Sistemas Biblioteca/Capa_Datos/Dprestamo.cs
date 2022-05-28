using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dprestamo
    {
        private int id_prestamo;
        private int id_alumno;
        private int id_libro;
        private DateTime fecha_prestamo;
        private DateTime fecha_max;
        private string Estado_prestamo;



        public int Id_prestamo
        {
            get { return id_prestamo; }
            set { id_prestamo = value; }
        }
        public int Id_alumno
        {
            get { return id_alumno; }
            set { id_alumno = value; }
        }
        public int Id_libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }
        public DateTime Fecha_prestamo
        {
            get { return fecha_prestamo; }
            set { fecha_prestamo = value; }
        }
        public DateTime Fecha_max
        {
            get { return fecha_max; }
            set { fecha_max = value; }
        }
        public string Estado_prestamo1
        {
            get { return Estado_prestamo; }
            set { Estado_prestamo = value; }
        }

        public Dprestamo()
        {
            //metodo vacio
        }

        public Dprestamo(int id_prestamo,int id_alumno,int id_libro,DateTime fecha_prestamo,DateTime fecha_dev,string estado_pres)
        {
            this.Id_prestamo = id_prestamo;
            this.Id_alumno = id_alumno;
            this.Id_libro = id_libro;
            this.Fecha_prestamo = fecha_prestamo;
            this.Fecha_max = fecha_dev;
            this.Estado_prestamo1 = estado_pres;
        }

        //metodo insertar

        public string insertar(Dprestamo pres)
        {
            SqlConnection con = new SqlConnection();
            string rpta = "";
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insertar_prestamos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_alumno = new SqlParameter();
                Pid_alumno.ParameterName = "@id_alumno";
                Pid_alumno.SqlDbType = SqlDbType.Int;
                Pid_alumno.Value = pres.Id_alumno;
                cmd.Parameters.Add(Pid_alumno);

                SqlParameter Pid_libro = new SqlParameter();
                Pid_libro.ParameterName = "@id_libro";
                Pid_libro.SqlDbType = SqlDbType.Int;
                Pid_libro.Value = Id_libro;
                cmd.Parameters.Add(Pid_libro);


                SqlParameter Pfecha_max = new SqlParameter();
                Pfecha_max.ParameterName = "@fecha_max";
                Pfecha_max.SqlDbType = SqlDbType.Date;
                Pfecha_max.Value = Fecha_max;
                cmd.Parameters.Add(Pfecha_max);


                rpta = cmd.ExecuteNonQuery() == 1 ? "No se Inserto Nada" : "OK";



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

        public string editar(Dprestamo pres)
        {
            SqlConnection con = new SqlConnection();
            string rpta = "";
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "editar_prestamos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_prestamo = new SqlParameter();
                Pid_prestamo.ParameterName = "@id_prestamo";
                Pid_prestamo.SqlDbType = SqlDbType.Int;
                Pid_prestamo.Value = Id_prestamo;
                cmd.Parameters.Add(Pid_prestamo);

                SqlParameter Pid_alumno = new SqlParameter();
                Pid_alumno.ParameterName = "@id_alumno";
                Pid_alumno.SqlDbType = SqlDbType.Int;
                Pid_alumno.Value = pres.Id_alumno;
                cmd.Parameters.Add(Pid_alumno);

                SqlParameter Pid_libro = new SqlParameter();
                Pid_libro.ParameterName = "@id_libro";
                Pid_libro.SqlDbType = SqlDbType.Int;
                Pid_libro.Value = Id_libro;
                cmd.Parameters.Add(Pid_libro);

           

                SqlParameter Pfecha_max = new SqlParameter();
                Pfecha_max.ParameterName = "@fecha_max";
                Pfecha_max.SqlDbType = SqlDbType.Date;
                Pfecha_max.Value = Fecha_max;
                cmd.Parameters.Add(Pfecha_max);


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Edito Nada";



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
            DataTable dt = new DataTable("Prestamos");
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "mostrar_prestamos";
            sqlcmd.CommandType = CommandType.StoredProcedure;

         

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);

            return dt;


        }

        public string eliminar(Dprestamo pres)
        {
            SqlConnection con = new SqlConnection();
            string rpta = "";
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "eliminar_prestamos";
                cmd.CommandType = CommandType.StoredProcedure;

             

                SqlParameter Pid_prestamo = new SqlParameter();
                Pid_prestamo.ParameterName = "@id_prestamo";
                Pid_prestamo.SqlDbType = SqlDbType.Int;
                Pid_prestamo.Value = Id_prestamo;
                cmd.Parameters.Add(Pid_prestamo);

                


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Edito Nada";



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

        public string retornar(Dprestamo pres)
        {
            SqlConnection con = new SqlConnection();
            string rpta = "";
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "retornar_libro";
                cmd.CommandType = CommandType.StoredProcedure;



                SqlParameter Pid_prestamo = new SqlParameter();
                Pid_prestamo.ParameterName = "@id_prestamo";
                Pid_prestamo.SqlDbType = SqlDbType.Int;
                Pid_prestamo.Value = Id_prestamo;
                cmd.Parameters.Add(Pid_prestamo);

                SqlParameter Pid_libro = new SqlParameter();
                Pid_libro.ParameterName = "@id_libro";
                Pid_libro.SqlDbType = SqlDbType.Int;
                Pid_libro.Value = Id_libro;
                cmd.Parameters.Add(Pid_libro);



                rpta = cmd.ExecuteNonQuery() == 1 ? "No Se Retorno Nada" : "OK";



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
     


    }
}
