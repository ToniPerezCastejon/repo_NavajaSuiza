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
    /// Clase pública parcial <see cref="frmNumerosPrimos"/> de tipo <see cref="Form"/>
    /// </summary>
    public partial class frmNumerosPrimos : Form
    {

        /// <summary>
        /// Constructor del formulario <see cref="frmNumerosPrimos"/>
        /// </summary>
        public frmNumerosPrimos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que recoge un número entero mediante textbox, y lanza el método <see cref="ComprobarPrimo(int)"/> para comprobar si dicho número es primo
        /// </summary>
        ///  <remarks>El booleano recibido por el método <see cref="ComprobarPrimo(int)"/> determina si el número es primo o no </remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            int iNumUsuario;
            bool bEsPrimo = true;
            bool bCorrecto;


            bCorrecto = int.TryParse(txtNumeroUsuario.Text, out iNumUsuario);

            if (!bCorrecto)
            {
                MessageBox.Show("No es un número entero correcto.");
            }
            else
            {
                bEsPrimo = ComprobarPrimo(iNumUsuario);

                if (bEsPrimo)
                {
                    MessageBox.Show("El número " + iNumUsuario + " es primo");
                }
                else
                {
                    MessageBox.Show("El número " + iNumUsuario + " no es primo");
                }
            }

        }

        /// <summary>
        /// Método que recibe un número de tipo entero, comprueba si dicho número es primo o no, y devuelve un booleano
        /// </summary>
        /// <remarks> 
        /// El contador i se inicia en 2, incrementándose en + 1 en cada iteración del while,
        /// hasta un máximo de <paramref name="iNumero"/> / 2
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el método, que comprobará si es o no es primo</param>
        /// <returns> Booleano que determina si <paramref name="iNumero"/> es primo o no</returns>
        bool ComprobarPrimo(int iNumero)
        {
            bool bEsPrimo = true;
            int iModulo = 0;
            int i = 2;


            while(i <= iNumero / 2 && bEsPrimo)
            {
                iModulo = iNumero % i;

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
