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
///  Espacio de nombres para la aplicación <see cref="NavajaSuiza.Aplicación_4_PotenciaNumero"/>
/// </summary>
namespace NavajaSuiza.Aplicación_4_PotenciaNumero
{
    /// <summary>
    /// Clase pública parcial <see cref="frmPotenciaNumero"/> de tipo <see cref="Form"/>
    /// </summary>
    public partial class frmPotenciaNumero : Form
    {
        /// <summary>
        /// Constructor del formulario <see cref="frmPotenciaNumero"/>
        /// </summary>
        public frmPotenciaNumero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que recoge mediante TextBox dos números enteros -una base y un exponente- y lanza el método <see cref="CalcularPotencia(int, int)"/> 
        /// para calcular la potencia
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnPotenciaNumero_Click(object sender, EventArgs e)
        {
            int iBase = int.Parse(txtBase.Text);
            int iExponente = int.Parse(txtExponente.Text);
            int iResultado;


            iResultado = CalcularPotencia(iBase, iExponente);
            MessageBox.Show(iResultado.ToString());
        }

        /// <summary>
        /// Método que calcula la potencia de un número base elevado a un número exponente
        /// </summary>
        /// <remarks> El método también es capaz de operar con números negativos</remarks>
        /// <param name="iBase"> Base o número cuya potencia queremos calcular</param>
        /// <param name="iExponente"> Exponente o número al que elevaremos la base</param>
        /// <returns> El resultado de calcular la potencia de <paramref name="iBase"/> elevado a <paramref name="iExponente"/> </returns>
        int CalcularPotencia(int iBase, int iExponente)
        {
            int iResultado = 1;
            bool bPositivo = true;


            if (iExponente < 0)
            {
                bPositivo = false;
                iExponente = -iExponente;
            }

            for (int i = 1; i <= iExponente; i++)
            {
                iResultado = iResultado * iBase;
            }

            if (bPositivo == false)
            {
                iResultado = 1 / iResultado;
            }

            return iResultado;
        }
    }
}
