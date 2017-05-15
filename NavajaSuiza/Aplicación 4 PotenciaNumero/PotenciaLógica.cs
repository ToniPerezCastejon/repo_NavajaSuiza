using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NavajaSuiza.Aplicación_4_PotenciaNumero
{
    /// <summary>
    /// Clase <see cref="PotenciaLógica"/> 
    /// </summary>
    public static class PotenciaLógica
    {

        /// <summary>
        /// Método que calcula la potencia de un número entero <paramref name="iBase"/>  elevado a un número entero <paramref name="iExponente"/>,
        /// devolviendo un valor de tipo <see cref="double"/> 
        /// </summary>
        /// <remarks> El método también es capaz de operar con números negativos</remarks>
        /// <param name="iBase"> Base o número cuya potencia queremos calcular</param>
        /// <param name="iExponente"> Exponente o número al que elevaremos la base</param>
        /// <returns> El resultado de calcular la potencia de <paramref name="iBase"/> elevado a <paramref name="iExponente"/> </returns>
        public static double CalcularPotencia(int iBase, int iExponente)
        {
            double dResultado = 1;
            bool bPositivo = true;


            if (iExponente < 0)
            {
                bPositivo = false;
                iExponente = -iExponente;
            }

            for (int i = 1; i <= iExponente; i++)
            {
                dResultado = dResultado * iBase;
            }

            if (bPositivo == false)
            {
                dResultado = 1 / dResultado;
            }

            return dResultado;
        }
    }
}

