using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Espacio de nombres para la aplicación <see cref="NavajaSuiza.Aplicación_1_NumerosPrimos"/>
/// </summary>
namespace NavajaSuiza.Aplicación_1_NumerosPrimos
{
    /// <summary>
    /// Clase pública parcial <see cref="frmNumerosPrimos"/> 
    /// </summary>
    public partial class frmNumerosPrimos : Form
    {

        /// <summary>
        /// ¿Constructor o inicializador del formulario <see cref="frmNumerosPrimos"/>? 
        /// </summary>
        public frmNumerosPrimos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que recoge un número entero mediante textbox, y lanza el método <see cref="ComprobarPrimo(int)"/> para comprobar si dicho número es primo
        /// </summary>
        ///  <remarks>El booleano recibido por el método <see cref="ComprobarPrimo(int)"/> determina si el número es primo o no </remarks>
        /// <param name="sender"> parámetro de tipo object </param>
        /// <param name="e"> parámetro de la clase EventArgs </param>
        private void button1_Click(object sender, EventArgs e)
        {
            int iNumUsuario;
            bool bEsPrimo = true;


            iNumUsuario = int.Parse(txtNumeroUsuario.Text);
            bEsPrimo = ComprobarPrimo(iNumUsuario);

            if(bEsPrimo)
            {
                MessageBox.Show("El número " + iNumUsuario + " es primo");
            }
            else
            {
                MessageBox.Show("El número " + iNumUsuario + " no es primo");
            }
        }

        /// <summary>
        /// Método que recibe un número de tipo entero, comprueba si dicho número es primo o no, y devuelve un booleano
        /// </summary>
        /// <remarks> 
        /// el contador i se inicia en 2, incrementándose en + 1 en cada iteración del while,
        /// hasta un máximo de <paramref name="numero"/> / 2
        /// </remarks>
        /// <param name="numero"> valor de tipo int recogido por el método, que comprobará si es o no es primo</param>
        /// <returns> el booleano que determina si <paramref name="numero"/> es primo o no</returns>
        bool ComprobarPrimo(int numero)
        {
            bool bEsPrimo = true;
            int iModulo = 0;
            int i = 2;


            while(i <= numero / 2 && bEsPrimo)
            {
                iModulo = numero % i;

                if(iModulo == 0)
                {
                    bEsPrimo = false;
                }

                i++;
            }

            return bEsPrimo;
        }
    }
}
