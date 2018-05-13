using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerClase02
{
    class sello
    {

        public static string mensaje;

        public static void Imprimir()
        {
            Console.WriteLine("{0}", sello.mensaje);
        }

        public static void Borrar()
        {

            Console.Clear();
        
        }

    }
}
