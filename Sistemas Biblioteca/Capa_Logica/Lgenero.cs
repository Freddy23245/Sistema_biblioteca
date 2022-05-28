using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Lgenero
    {
        public static string insertar(string nombre)
        {
            Dgenero genero = new Dgenero();
            genero.Nombre = nombre;
            return genero.insertar(genero);
        }

        public static string editar(int id_genero,string nombre)
        {
            Dgenero genero = new Dgenero();
            genero.Id_genero = id_genero;
            genero.Nombre = nombre;
            return genero.editar(genero);
        }
        public static string eliminar(int id_genero)
        {
            Dgenero genero=new Dgenero();
            genero.Id_genero=id_genero;
            return genero.eliminar(genero);


    }
        public static DataTable mostrar()
        {
            return new Dgenero().mostrar();
        }
}

}