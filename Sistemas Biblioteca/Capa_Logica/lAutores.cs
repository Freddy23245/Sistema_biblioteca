using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Datos;
using System.Data;
namespace Capa_Logica
{
    public class lAutores
    {
        public static string insertar(string nombre,string apellido,string mail)
        {
            Dautores autor = new Dautores();
            autor.Nombre = nombre;
            autor.Apellido = apellido;
            autor.Mail = mail;
            return autor.insertar(autor);
        }

        public static string editar(int id_autor,string nombre,string apellido,string mail)
        {
            Dautores autor = new Dautores();
            autor.Id_autor = id_autor;
            autor.Nombre = nombre;
            autor.Apellido = apellido;
            autor.Mail = mail;
            return autor.editar(autor);

        }
        public static string eliminar(int id_autor)
        {
            Dautores autor = new Dautores();
            autor.Id_autor = id_autor;
            return autor.eliminar(autor);
        }

        public static DataTable mostrar()
        {
            return new Dautores().mostrar();
        }
     
    }
}
