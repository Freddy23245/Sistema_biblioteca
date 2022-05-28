using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;
namespace Capa_Logica
{
    public class Lprestar
    {
        public static string insertar(int id_alumno, int id_libro, DateTime fecha_max)
        {
            Dprestamo pres = new Dprestamo();
            pres.Id_alumno = id_alumno;
            pres.Id_libro = id_libro;
          
            pres.Fecha_max = fecha_max;
            return pres.insertar(pres);

        }
        public static string editar(int id_prestamo, int id_alumno, int id_libro, DateTime fecha_max)
        {
            Dprestamo pres = new Dprestamo();
            pres.Id_prestamo = id_prestamo;
            pres.Id_alumno = id_alumno;
            pres.Id_libro = id_libro;
           
            pres.Fecha_max = fecha_max;
            return pres.editar(pres);

        }

        //public static DataTable mostrar_deuda(int id_alumno)
        //{
        //    Dprestamo Prest = new Dprestamo();
        //    Prest.Id_alumno = id_alumno;
        //    return Prest.VerificarLector(Prest);

        //}
        public static DataTable mostrar()
        {
            return new Dprestamo().mostar();
        }

        public static string retornar(int id_prestamo,int id_libro)
        {
            Dprestamo pres=new Dprestamo();
            pres.Id_prestamo=id_prestamo;
            pres.Id_libro = id_libro;
            return pres.retornar(pres);
        }
        public static string eliminar(int id_prestamo)
        {
            Dprestamo pres=new Dprestamo();
            pres.Id_prestamo=id_prestamo;
            return pres.eliminar(pres);
        }
    

    }
}
