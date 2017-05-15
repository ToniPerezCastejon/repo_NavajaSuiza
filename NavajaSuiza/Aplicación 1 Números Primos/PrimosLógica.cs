using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NavajaSuiza.Aplicación_1_NumerosPrimos
{
    /// <summary>
    /// Clase <see cref="PrimosLógica"/> 
    /// </summary>
    public static class PrimosLógica
    {

        /// <summary>
        /// Método que recibe un número de tipo entero, comprueba si dicho número es primo o no, y devuelve un booleano
        /// </summary>
        /// <remarks> 
        /// El contador i se inicia en 2, incrementándose en + 1 en cada iteración del while,
        /// hasta un máximo de <paramref name="iNumero"/> / 2
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el método, que comprobará si es o no es primo</param>
        /// <returns> Booleano que determina si <paramref name="iNumero"/> es primo o no</returns>
        public static bool ComprobarPrimo(int iNumero)
        {
            bool bEsPrimo = true;
            int iModulo = 0;
            int i = 2;


            while (i <= iNumero / 2 && bEsPrimo)
            {
                iModulo = iNumero % i;

                if (iModulo == 0)
                {
                    bEsPrimo = false;
                }

                i++;
            }

            return bEsPrimo;
        }


    }
}

