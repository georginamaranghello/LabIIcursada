using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;


        public float getArea()
        { 
            return this.area;
        
        }

        public float getPerimetro()

        {

            return this.perimetro;
        }


        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public double Area() 
        {

            double vArea;
            int alto;
            int ancho;

            alto = Math.Abs((this.vertice1.getX, this.vertice1.getY) - (this.vertice2.getY, this.vertice2.getY));
            ancho = Math.Abs(vertice1 - vertice4);

            vArea = alto * ancho;

                return vArea;
        
        }


        public float Perimetro() 
        {
            float vPerim;

            vPerim = Math.Abs((vertice1 - vertice2) + (vertice1 - vertice4)) * 2;


                return vPerim;
        
        
        }


        public Rectangulo(Punto vertice1, Punto vertice3)
        {

            




        }
    }
}
