using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// namespace de la aplicación1
/// </summary>
namespace NavajaSuiza.Aplicación_1
{
    /// <summary>
    /// clase que ejecuta la lógica de la aplicación 1
    /// </summary>
    class Aplicacion1
    {
        /// <summary>
        /// contructor de la clase
        /// </summary>
        /// <remarks>Sin uso</remarks>
        public Aplicacion1()
        {
            //sin uso
        }


        private int myVar;
        /// <summary>
        /// propiedad de la clase Aplicacion1
        /// </summary>
        /// <remarks>Sin uso</remarks>
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


       /// <summary>
       /// devuelve un valor
       /// </summary>
       /// <returns>un cadena con un mensaje</returns>
        public string Metodo()
        {
            return "son la clase Aplicacion1 y te devuelvo el valor: Hola Mundo!";
        }
    }
}
