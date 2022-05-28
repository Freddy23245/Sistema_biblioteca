using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace Capa_Datos
{
    public class Dusuarios
    {

        private int id_usuario;
        private string nombre;
        private string usuario;
        private string contraseña;
        private int intentopass;
        private bool habilitado;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

      
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public int Intentopass
        {
            get { return intentopass; }
            set { intentopass = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }


        public string insertar(Dusuarios usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "agregarUsuarios";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 50;
                Pnombre.Value = usuario.Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Pusuario = new SqlParameter();
                Pusuario.ParameterName = "@usuario";
                Pusuario.SqlDbType = SqlDbType.VarChar;
                Pusuario.Size = 30;
                Pusuario.Value = usuario.Usuario;
                cmd.Parameters.Add(Pusuario);

                SqlParameter Pcontraseña=new SqlParameter();
                Pcontraseña.ParameterName="@contraseña";
                Pcontraseña.SqlDbType=SqlDbType.VarChar;
                Pcontraseña.Size=255;
                Pcontraseña.Value=usuario.Contraseña;
                cmd.Parameters.Add(Pcontraseña);

                SqlParameter Phab=new SqlParameter();
                Phab.ParameterName="@habilitado";
                Phab.SqlDbType=SqlDbType.Bit;
                Phab.Value=usuario.Habilitado;
                cmd.Parameters.Add(Phab);

                SqlParameter Pemail = new SqlParameter();
                Pemail.ParameterName = "@email";
                Pemail.SqlDbType = SqlDbType.VarChar;
                Pemail.Size = 50;
                Pemail.Value = usuario.Habilitado;
                cmd.Parameters.Add(Pemail);

                rpta=cmd.ExecuteNonQuery()==1?"OK":"No Se Inserto Nada";



            }catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if(con.State==ConnectionState.Open)con.Close();
            }
            return rpta;

            
    }
        public string editar(Dusuarios usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "editarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_usuario = new SqlParameter();
                Pid_usuario.ParameterName = "@id_usuario";
                Pid_usuario.SqlDbType = SqlDbType.Int;
                Pid_usuario.Value = usuario.Id_usuario;
                cmd.Parameters.Add(Pid_usuario);

                SqlParameter Pnombre = new SqlParameter();
                Pnombre.ParameterName = "@nombre";
                Pnombre.SqlDbType = SqlDbType.VarChar;
                Pnombre.Size = 50;
                Pnombre.Value = usuario.Nombre;
                cmd.Parameters.Add(Pnombre);

                SqlParameter Pusuario = new SqlParameter();
                Pusuario.ParameterName = "@usuario";
                Pusuario.SqlDbType = SqlDbType.VarChar;
                Pusuario.Size = 30;
                Pusuario.Value = usuario.Usuario;
                cmd.Parameters.Add(Pusuario);

                SqlParameter Pcontraseña=new SqlParameter();
                Pcontraseña.ParameterName="@contraseña";
                Pcontraseña.SqlDbType=SqlDbType.VarChar;
                Pcontraseña.Size=255;
                Pcontraseña.Value=usuario.Contraseña;
                cmd.Parameters.Add(Pcontraseña);

                SqlParameter Phab=new SqlParameter();
                Phab.ParameterName="@habilitado";
                Phab.SqlDbType=SqlDbType.Bit;
                Phab.Value=usuario.Habilitado;
                cmd.Parameters.Add(Phab);

                SqlParameter Pemail = new SqlParameter();
                Pemail.ParameterName = "@email";
                Pemail.SqlDbType = SqlDbType.VarChar;
                Pemail.Size = 50;
                Pemail.Value = usuario.Email;
                cmd.Parameters.Add(Pemail);

                rpta=cmd.ExecuteNonQuery()==1?"OK":"No Se Inserto Nada";



            }catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if(con.State==ConnectionState.Open)con.Close();
            }
            return rpta;
            }

        public string eliminar(Dusuarios usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "eliminarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pid_usuario = new SqlParameter();
                Pid_usuario.ParameterName = "@id_usuario";
                Pid_usuario.SqlDbType = SqlDbType.Int;
                Pid_usuario.Value = usuario.Id_usuario;
                cmd.Parameters.Add(Pid_usuario);

              

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se elimino Nada";



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
            DataTable dt = new DataTable("Usuarios");
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "mostrar_usuarios";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);




            return dt;


        }
         
        public string loger(string usu,string contraseña)
           

        {
            SqlConnection sqlcon = new SqlConnection();
            string men = "";
            try
            {
                
              
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "verificar_usuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;

                cmd.Parameters.Add(new SqlParameter("@usuario", usu));
                cmd.Parameters.Add(new SqlParameter("@contraseña", contraseña));

                SqlParameter Pmen = new SqlParameter("@msje", SqlDbType.VarChar);
                Pmen.Direction = ParameterDirection.Output;
                Pmen.Size = 100;
                cmd.Parameters.Add(Pmen);

                cmd.ExecuteNonQuery();

                men = cmd.Parameters["@msje"].Value.ToString();

                return men;
            }
            catch (Exception ex)
            {

                men = ex.Message;
                return men;
            }
            finally
            {
                sqlcon.Close();
            }

        }

        public DataTable perMenu(string usu)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conexion.cn;
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "validar_permiso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            DataTable dt=new DataTable();

            dt.Load(dr);
            return dt;






            }


        public string RecPass(Dusuarios usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UpdatePass";
                cmd.CommandType = CommandType.StoredProcedure;

              
                SqlParameter Pemail = new SqlParameter();
                Pemail.ParameterName = "@email";
                Pemail.SqlDbType = SqlDbType.VarChar;
                Pemail.Size = 50;
                Pemail.Value = usuario.Email;
                cmd.Parameters.Add(Pemail);

                SqlParameter Pcontraseña = new SqlParameter();
                Pcontraseña.ParameterName = "@contraseña";
                Pcontraseña.SqlDbType = SqlDbType.VarChar;
                Pcontraseña.Size = 255;
                Pcontraseña.Value = usuario.Contraseña;
                cmd.Parameters.Add(Pcontraseña);

            

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No Se Inserto Nada";



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

