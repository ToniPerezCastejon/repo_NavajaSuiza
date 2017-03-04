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
/// Espacio de nombres para la aplicación <see cref="NavajaSuiza"/>
/// </summary>
namespace NavajaSuiza
{
    /// <summary>
    /// Clase pública parcial <see cref="frmMain"/> de tipo <see cref="Form"/>
    /// </summary>
    /// <remarks> Este formulario contiene los botones que nos redireccionan a los formularios de todas las aplicaciones que contiene la solución</remarks>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Constructor del formulario <see cref="frmMain"/>
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a la aplicación: <see cref="Aplicación_1_NumerosPrimos"/> 
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            Aplicación_1_NumerosPrimos.frmNumerosPrimos oFormulario = new Aplicación_1_NumerosPrimos.frmNumerosPrimos();
            oFormulario.ShowDialog();          
         }

        /// <summary>
        /// Llama a la aplicación: <see cref="Aplicación_2_ValidarFecha"/> 
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnValidarFecha_Click(object sender, EventArgs e)
        {
            Aplicación_2_ValidarFecha.frmValidarFecha oFormulario = new Aplicación_2_ValidarFecha.frmValidarFecha();
            oFormulario.ShowDialog();
        }


        /// <summary>
        /// Llama a la aplicación: <see cref="Aplicación_3_JuegoAdivinarNumero"/> 
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnJuegoAdivinarNumero_Click(object sender, EventArgs e)
        {
            Aplicación_3_JuegoAdivinarNumero.frmJuegoAdivinarNumero oFormulario = new Aplicación_3_JuegoAdivinarNumero.frmJuegoAdivinarNumero();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Llama a la aplicación: <see cref="Aplicación_4_PotenciaNumero"/> 
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object</param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnPotenciaNumero_Click(object sender, EventArgs e)
        {
            Aplicación_4_PotenciaNumero.frmPotenciaNumero oFormulario = new Aplicación_4_PotenciaNumero.frmPotenciaNumero();
            oFormulario.ShowDialog();
        }
    }
}
