using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Lalumnos
    {

        //llamare al metodo insertar de la capa de datos
        public static string insertar(string nombre,string apellido,string dni,string telefono,string direccion,string mail)
        {
            Dalumnos obj=new Dalumnos();

            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Dni = dni;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Mail = mail;
            return obj.insertar(obj);

        }
        //metodo de editar
        public static string editar(int id_alumno,string nombre,string apellido,string dni,string telefono,string direccion,string mail)
        {
            Dalumnos obj = new Dalumnos();

            obj.Id_alumno = id_alumno;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Dni = dni;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Mail = mail;
            return obj.editar(obj);
        }
        //metodo eliminar
        public static string eliminar(int id_alumno)
        {
            Dalumnos obj = new Dalumnos();

            obj.Id_alumno = id_alumno;
           
            return obj.eliminar(obj);
        }
        public static DataTable mostrar()
        {
            return new Dalumnos().mostar();
        }


        public static DataTable Deuda2(int id_alumno)
        {
            Dalumnos al = new Dalumnos();


            return al.Deuda(id_alumno);

        }
        
    }
}
