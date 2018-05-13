using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLibrary
{
    class cosa
    {

        public int entero;
        public string cadena;
        public DateTime fecha;

        //constructor por valor explicito, cargo los valores con datos
        public cosa():this(10, "sin valor", DateTime.Now)
        {
            
        }

        //costructor que permita al usuario pasar valores por parametro
        public cosa(int a, string c, DateTime f)
        {
            this.entero = a;
            this.cadena = c;
            this.fecha = f;
        
        }

        //constructor que permite que el usuario ingrese el entero y el string como parametro pero la fecha es por default
        public cosa(int b, string c)
        {

            this.entero = b;
            this.cadena = c;
            this.fecha = DateTime.Now;
 
        }

        //constructor que permite que el usuario ingrese el entero como parametro pero los demas datos son por default
        public cosa(int c)
        {
            this.entero = c;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        
        }


        /// <summary>
        /// Establecer un valor para algun atributo de la clase
        /// </summary>
        /// <param name="a"> parametro que inicializara el atributo entero de nuestra clase</param>
        public void EstablecerValor(int a)
        {
            this.entero = a;
        
        }

        /// <summary>
        ///  Establecer un valor para algun atributo de la clase
        /// </summary>
        /// <param name="cad">parametro que inicializara el atributo string de nuestra clase</param>
        public void EstablecerValor(string cad)
        {

            this.cadena = cad;
        
        }

        /// <summary>
        /// Establecer un valor para algun atributo de la clase
        /// </summary>
        /// <param name="f">parametro que inicializara el atributo string de nuestra clase</param>
        public void EstablecerValor(DateTime f)
        {
            this.fecha = f;
        }

        /// <summary>
        /// Muestra los valores de los atributos de la clase
        /// </summary>
        /// <returns>string</returns>
        public string Mostrar()
        {

            string c;

            c = this.cadena +"\n" + this.entero +"\n"+ this.fecha;
            Console.WriteLine(c);

            return c;
        
        }
        ///
        /// 
        /// para reutilizar codigo en los constructores se puede hacer lo siguinte: invocar desde una sobrecarga de un 
        /// onstructor a otra sobrecarga de constructor
        /// 
        /// public cosa (): this(10, "sin valor", DateTime.Now)  el constructor llama al constructor por default para asignar los valores
        /// que se le pasan como parametro al this
        /// 
        /// 
        /// en este caso:
        /// 
        /// public cosa(int c)
       ///      {
        //    this.entero = c;
        //    this.cadena = "sin valor";
         //   this.fecha = DateTime.Now;
        //      }
        // sepuede hacer lo siguiente:
        ///public cosa (int c) :this(c, "sin valor", Datetime.Now)
        /// 
        /// 
        /// 
        /// 









      

    }
}
