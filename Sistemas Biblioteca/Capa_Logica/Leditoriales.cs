using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Leditoriales
    {

        public static string insertar(string nombre)
        {
            DEditoriales editorial = new DEditoriales();
            editorial.Nombre = nombre;
            return editorial.insertar(editorial);

        }

        public static string editar(int id_editorial,string nombre)
        {
            DEditoriales editorial = new DEditoriales();
            editorial.Id_editorial = id_editorial;
            editorial.Nombre = nombre;
            return editorial.editar(editorial);
        }

        public static string eliminar(int id_editorial)
        {
            DEditoriales editorial = new DEditoriales();
            editorial.Id_editorial = id_editorial;
            return editorial.eliminar(editorial);

        }
        public static DataTable mostrar()
        {
            return new DEditoriales().mostrar();
        }

    }
}
