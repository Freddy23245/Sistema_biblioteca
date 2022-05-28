using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Llibros
    {
            public static string insetar(int id_autor,int id_genero,int id_editorial,string nombre,DateTime año)
        {
            Dlibro libro = new Dlibro();

            libro.Id_editor = id_autor;
            libro.Id_genero = id_genero;
            libro.Id_editorial = id_editorial;
            libro.Nombre = nombre;
            libro.Año_publicacion = año;
           
            return libro.insertar(libro);

        }
        public static string editar(int id_libro,int id_autor,int id_genero,int id_editorial,string nombre,DateTime año)
            {
                Dlibro libro = new Dlibro();

                libro.Id_libro = id_libro;
                libro.Id_editor = id_autor;
                libro.Id_genero = id_genero;
                libro.Id_editorial = id_editorial;
                libro.Nombre = nombre;
                libro.Año_publicacion = año;
                
                return libro.editar(libro);
            }

            public static string eliminar(int id_libro)
        {
            Dlibro libro = new Dlibro();

            libro.Id_libro = id_libro;
            return libro.eliminar(libro);
        }
        public static DataTable mostrar()
            {
                return new Dlibro().mostar();
            }
    }
}
