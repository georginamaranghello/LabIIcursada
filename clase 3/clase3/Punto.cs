using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria

{
    class Punto
    {
        private int x;
        private int y;


        public int getX()
        {

            return this.x;

        }

        public int getY()
        {
            return this.y;
        }


        public Punto(int n1, int n2)
        {
            this.x = n1;
            this.y = n2;



        }

    }
}
