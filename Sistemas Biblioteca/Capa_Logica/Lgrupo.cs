using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
namespace Capa_Logica
{
    public class Lgrupo
    {
        public static string insertarGps(string nombre)
        {
            Dgrupos grup = new Dgrupos();

            grup.Nombre = nombre;
            return grup.AgregarGps(grup);

        }





    }
}
