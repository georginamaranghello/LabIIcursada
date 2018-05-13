using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadSello
{
    public class sello
    {
        public static string mensaje;

        public static ConsoleColor color; 

        public static void Imprimir()
        {
            Console.ForegroundColor = sello.color; //setea el color en el cual se va a imp el mensaje
            Console.WriteLine("{0}", sello.mensaje); //imprime el mensaje en ese color
            Console.ForegroundColor = ConsoleColor.Gray; // vuelve el color al gris original

        }

        public static void Borrar()
        {

            Console.Clear();

        }

        private static bool TryParse(string, out string)
        {
        
            bool estaOk;

            if(entidadSello.sello.mensaje.Length==0)
            {
            
            

            
            }

            else{

                estaOk= true;
                entidadSello.sello.Imprimir();


            }

            return estaOk;
        
        }
            

       

        
        

    }
}
