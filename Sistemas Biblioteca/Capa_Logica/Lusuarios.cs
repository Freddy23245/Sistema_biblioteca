using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Logica
{    



    public class Lusuarios
    {

 

        public static string insertar(string nombre,string usuarios,string contraseña,bool habilitado,string email)
        {
            Dusuarios usuario = new Dusuarios();

            usuario.Nombre = nombre;
            usuario.Usuario = usuarios;
            usuario.Contraseña = contraseña;
            usuario.Habilitado = habilitado;
            usuario.Email = email;
            return usuario.insertar(usuario);
            


        }

        public static string editar(int id_usuario,string nombre,string usuarios,string contraseña,bool habilitado,string email)
        {
            Dusuarios usuario = new Dusuarios();

            usuario.Id_usuario = id_usuario;
            usuario.Nombre = nombre;
            usuario.Usuario = usuarios;
            usuario.Contraseña = contraseña;
            usuario.Habilitado = habilitado;
            usuario.Email = email;
            return usuario.editar(usuario);
        }

        public static string eliminar(int id_usuario)
        {
            Dusuarios usuario = new Dusuarios();

            usuario.Id_usuario = id_usuario;
            return usuario.eliminar(usuario);
        }

        public static DataTable mostrar()
        {
            return new Dusuarios().mostar();
        }


        
        public static string logL(string usu, string contr)
        {
            Dusuarios usuario = new Dusuarios();
            string msj;
                msj=usuario.loger(usu, contr);

                return msj; 



        }

        public static DataTable LperMenu(string usu)
        {
            Dusuarios us=new Dusuarios();


            return us.perMenu(usu);

        }


        public static string REc(string email, string contraseña)
        {
            Dusuarios usua = new Dusuarios();

            usua.Email = email;
            usua.Contraseña = contraseña;
            
            return usua.RecPass(usua);
        }
      
        }

        


        
        
    }

