using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classLibrary
{
    class Program
    {
        static void Main(string[] args)
        {


            int entero = 9;
            string cadena = "hola";
            DateTime fecha = DateTime.Now;
            //DateTime fCumple = new DateTime(05-04-2000);


            cosa c = new cosa();

            //la fecha se puede pasar parseandola o pasandole el objeto fecha fCumple creado mas arriba
            cosa c2 = new cosa(29, "Geo", DateTime.Parse("05-04-2000"));

            c2.Mostrar();

            c.Mostrar();

            c.EstablecerValor(entero);
            c.EstablecerValor(cadena);
            c.EstablecerValor(fecha);

            c.Mostrar();

            Console.ReadKey();


        }
    }
}
