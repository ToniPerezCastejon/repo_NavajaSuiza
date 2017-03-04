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
/// Espacio de nombres para la aplicación <see cref="NavajaSuiza.Aplicación_2_ValidarFecha"/>
/// </summary>
namespace NavajaSuiza.Aplicación_2_ValidarFecha
{
    /// <summary>
    /// Clase pública parcial <see cref="frmValidarFecha"/> de tipo <see cref="Form"/> 
    /// </summary>
    public partial class frmValidarFecha : Form
    {
        /// <summary>
        /// Constructor del formulario <see cref="frmValidarFecha"/>
        /// </summary>
        public frmValidarFecha()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que recoge una fecha, y lanza el método <see cref="ValidarFecha(int, int, int)"/> para comprobar si dicha fecha es válida
        /// </summary>
        /// <remarks>
        /// La fecha se desglosa en tres variables de tipo entero, recogidas mediante textbox, que se corresponden con el día, mes y año
        /// </remarks>
        /// <remarks>
        /// El booleano recibido por el método <see cref="ValidarFecha(int, int, int)"/> determina si la fecha introducida por el usuario es válida o no
        /// </remarks>
        /// <param name="sender"> Parámetro de tipo object</param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnValidarFecha_Click(object sender, EventArgs e)
        {
            int iDia = int.Parse(txtDia.Text);
            int iMes = int.Parse(txtMes.Text);
            int iAnyo = int.Parse(txtAnyo.Text);
            bool bFechaValida = true;


            bFechaValida = ValidarFecha(iDia, iMes, iAnyo);

            if (bFechaValida == true)
            {
                MessageBox.Show("La fecha introducida es válida");
            }
            else
            {
                MessageBox.Show("La fecha introducida NO es válida");
            }
        }

        /// <summary>
        /// Método que recoge tres parámetros de tipo entero (día, mes, año) correspondientes a una fecha, y determina si dicha fecha es válida o no
        /// </summary>
        /// <remarks> El método tiene en cuenta que los distintos meses pueden tener 28/29, 30 o 31 días </remarks>
        /// <remarks> 
        /// Lanza el método <see cref="ComprobarBisiesto(int)"/> que devuelve un booleano indicando si el año es bisiesto y,
        /// con dicho booleano, el método actual determina si el mes de febrero tiene 28 días (no bisiesto) o 29 días (bisiesto)
        /// </remarks>
        /// <param name="iDia"> El día de la fecha introducida por el usuario </param>
        /// <param name="iMes"> El mes de la fecha introducida por el usuario </param>
        /// <param name="iAnyo"> El año de la fecha introducida por el usuario </param>
        /// <returns> Booleano que indica si la fecha es válida o no </returns>
        bool ValidarFecha(int iDia, int iMes, int iAnyo)
        {
            bool bFechaValida = true;
            bool bBisiesto = false;


            if (iDia < 1 || iDia > 31 || iMes < 1 || iMes > 12)
            {
                bFechaValida = false;
            }
            else
            {
                switch (iMes)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (iDia > 30)
                        {
                            bFechaValida = false;
                        }
                        break;
                    case 2:
                        bBisiesto = ComprobarBisiesto(iAnyo);
                        if (bBisiesto == false && iDia > 28)
                        {
                            bFechaValida = false;
                        }
                        if (bBisiesto == true && iDia > 29)
                        {
                            bFechaValida = false;
                        }
                        break;
                }
            }

            return bFechaValida;
        }

        /// <summary>
        /// Método que recibe una variable de tipo entero, correspondiente a un año, y determina si dicho año es bisiesto o no, devolviendo un booleano
        /// </summary>
        /// <param name="iAnyo"> El año que comprobaremos si es bisiesto o no</param>
        /// <returns> Booleano que indica si el año es bisiesto o no</returns>
        bool ComprobarBisiesto(int iAnyo)
        {
            bool bBisiesto = false;


            if (iAnyo % 4 == 0)
            {
                bBisiesto = true;
                if (iAnyo % 100 == 0 && iAnyo % 400 != 0)
                {
                    bBisiesto = false;
                }
            }

            return bBisiesto;
        }
    }
}
