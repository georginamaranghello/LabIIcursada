using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria

{
    class Program
    {
        static void Main(string[] args)
        {


            Geometria.Punto vertice1 = new Geometria.Punto(3,9);
            Geometria.Punto vertice2 = new Geometria.Punto(7,9);
            Geometria.Punto vertice3 = new Geometria.Punto(2,1);
            Geometria.Punto vertice4 = new Geometria.Punto(3,7);




            double area;

            Geometria.Rectangulo rectangulo = new Geometria.Rectangulo(vertice1, vertice3);


            area = rectangulo.Area();
            Console.WriteLine("El area del rectangulo es: {0}" + area);

            Console.ReadLine();


        }
    }
}
