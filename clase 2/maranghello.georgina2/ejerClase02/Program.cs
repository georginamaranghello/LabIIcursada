using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerClase02
{
    class Program
    {
        static void Main(string[] args)
        {


            entidadSello.sello.color = ConsoleColor.DarkRed;  // selecciona el color del mensaje a imprimir


            entidadSello.sello.mensaje = "";

            entidadSello.sello.Imprimir(); //no se puede directamente pasar el mensaje como parametro

            Console.ReadLine();

            entidadSello.sello.Borrar();
         
            Console.WriteLine("Pulse una tecla para salir");
           
            Console.ReadKey();

           

           

           






        }
    }
}
