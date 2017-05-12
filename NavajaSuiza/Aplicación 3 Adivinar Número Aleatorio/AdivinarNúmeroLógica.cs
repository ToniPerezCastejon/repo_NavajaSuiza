using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Espacio de nombres utilizado para la clase 
/// </summary>
namespace NavajaSuiza.Aplicación_3_JuegoAdivinarNumero
{
    /// <summary>
    /// Clase <see cref="AdivinarNúmeroLógica"/> 
    /// </summary>
    /// <remarks> 
    /// Clase destinada a generar un objeto o instancia de un juego en el que el usuario
    /// debe adivinar un número aleatorio oculto, teniendo para ello hasta 6 intentos
    /// </remarks>
    public class AdivinarNúmeroLógica
    {
        private int mNumAleatorio;
        private int mIntentosRestantes;
        private ArrayList listNumeros;

        /// <summary>
        /// Propiedad <see cref="NumAleatorio"/> 
        /// </summary>
        /// <value> Número aleatorio de tipo entero que el usuario debe adivinar</value>
        public int NumAleatorio
        {
            get { return mNumAleatorio; }
            set { mNumAleatorio = value; }
        }

        /// <summary>
        /// Propiedad <see cref="IntentosRestantes"/> 
        /// </summary>
        /// <value> Variable usada como contador de intentos restantes para que el jugador adivine el número secreto </value>
        public int IntentosRestantes
        {
            get { return mIntentosRestantes; }
            set { mIntentosRestantes = value; }
        }

        /// <summary>
        /// Constructor de la clase <see cref="AdivinarNúmeroLógica"/> 
        /// </summary>
        /// <remarks> 
        /// Contiene los miembros <see cref="mNumAleatorio"/>, <see cref="mIntentosRestantes"/>
        /// y el ArrayList <see cref="listNumeros"/>, que almacena todos los valores que el usuario va introduciendo  
        /// </remarks>
        public AdivinarNúmeroLógica()
        {
            mNumAleatorio = 0;
            mIntentosRestantes = 6;
            listNumeros = new ArrayList();
        }


        /// <summary>
        /// Método que recibe un valor de tipo entero introducido por un usuario, y lo compara con el miembro <see cref="mNumAleatorio"/>,
        /// </summary>
        /// <remarks>
        /// Devuelve dos valores de tipo <see cref="int"/>: 
        /// el primero indica si el número introducido es igual, mayor o menor que <see cref="mNumAleatorio"/> 
        /// el segundo indica el número de intentos restantes para el usuario
        /// </remarks>
        /// <param name="iNumeroUsuario">El número introducido por el usuario </param>
        /// <param name="iCompareNums"> Devuelve un valor de tipo entero entre 3 posibles:
        /// 0 (<paramref name="iNumeroUsuario"/> = <see cref="mNumAleatorio"/>);  
        /// 1 (<paramref name="iNumeroUsuario"/> mayor que <see cref="mNumAleatorio"/>);
        /// -1 (<paramref name="iNumeroUsuario"/> menor que <see cref="mNumAleatorio"/>); 
        /// </param>
        /// <param name="iIntentosRestantes"> Devuelve un entero con el número de intentos restantes, tomado de <see cref="mIntentosRestantes"/> </param>
        public void JugarRandom(int iNumeroUsuario, out int iCompareNums, out int iIntentosRestantes)
        {
            iCompareNums = 0;

            listNumeros.Add(iNumeroUsuario);

            if (iNumeroUsuario == mNumAleatorio)
            {
                mIntentosRestantes--;
                iCompareNums = 0;
            }
            else
            {
                if (iNumeroUsuario < mNumAleatorio)
                {
                    mIntentosRestantes--;
                    iCompareNums = -1;
                }
                else
                {
                    mIntentosRestantes--;
                    iCompareNums = 1;
                }
            }
            iIntentosRestantes = mIntentosRestantes;
        }

        /// <summary>
        /// Método que devuelve una cadena de caracteres con todos los números introducidos por el usuario hasta el momento
        /// </summary>
        /// <remarks> La lista de números es extraída de <see cref="listNumeros"/> </remarks>
        /// <returns> String con todos los números introducidos por el usuario</returns>
        public string NumerosUsados()
        {
            string sNumerosUsados = "";

            for (int i = 0; i < listNumeros.Count; i++)
            {
                sNumerosUsados = sNumerosUsados + listNumeros[i] + ", ";
            }

            return sNumerosUsados;
        }
    }
}
