using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dgrupos
    {

        private int id_grupo;
        private string nombre;

        public int Id_grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Dgrupos()
        {

        }

        public Dgrupos(string nombre)
        {
            this.Nombre=nombre;
        }


        public string AgregarGps(Dgrupos grup)
        {
            string rpta = "";

            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Agregar_Grupos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 50;
                Pnombre.Value = grup.Nombre;
                cmd.Parameters.Add(Pnombre);



                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Inserto El Grupo";




            }catch(Exception ex)
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
