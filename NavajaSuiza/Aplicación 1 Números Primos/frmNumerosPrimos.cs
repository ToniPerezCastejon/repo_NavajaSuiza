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
        /// Evento que recoge un número entero mediante textbox, y lanza el método <see cref="PrimosLógica.ComprobarPrimo(int)"/> para comprobar si dicho número es primo
        /// </summary>
        ///  <remarks>El booleano recibido por el método <see cref="PrimosLógica.ComprobarPrimo(int)"/> determina si el número es primo o no </remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            int iNumUsuario;
            bool bCorrecto = int.TryParse(txtNumeroUsuario.Text, out iNumUsuario);
            bool bEsPrimo = true;

            if (bCorrecto)
            {
                try
                {
                    bEsPrimo = PrimosLógica.ComprobarPrimo(iNumUsuario);

                    if (bEsPrimo)
                    {
                        MessageBox.Show("El número " + iNumUsuario + " es primo");
                    }
                    else
                    {
                        MessageBox.Show("El número " + iNumUsuario + " no es primo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error:" + ex.Message);
                }
            }

        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox <see cref="txtNumeroUsuario"/> 
        /// </summary>
        /// <remarks> Activa o desactiva el botón <see cref="btnNumerosPrimos"/> en función del valor de <see cref="txtNumeroUsuario"/></remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Instancia que contiene los datos del evento <see cref="EventArgs"/> </param>
        private void txtNumeroUsuario_TextChanged(object sender, EventArgs e)
        {
            int iNumUsuario;
            bool bCorrecto;

            if (String.IsNullOrWhiteSpace(txtNumeroUsuario.Text))
            {
                btnNumerosPrimos.Enabled = false;
                lblError.Text = "";
            }
            else
            {
                bCorrecto = int.TryParse(txtNumeroUsuario.Text, out iNumUsuario);

                if (!bCorrecto)
                {
                    long lngNumero;
                    bCorrecto = long.TryParse(txtNumeroUsuario.Text, out lngNumero);

                    if (bCorrecto)
                    {
                        if (lngNumero > Int32.MaxValue)
                        {
                            btnNumerosPrimos.Enabled = false;
                            lblError.Text = "¡Error!\n\n" + txtNumeroUsuario.Text + " no es un número entero correcto\n\n El número introducido debe ser menor que " + Int32.MaxValue;
                        }
                        else
                        {
                            if (lngNumero < Int32.MinValue)
                            {
                                btnNumerosPrimos.Enabled = false;
                                lblError.Text = "¡Error!\n\n" + txtNumeroUsuario.Text + " no es un número entero correcto\n\n El número introducido debe ser un número positivo mayor que 0";
                            }
                        }
                    }
                    else
                    {
                        btnNumerosPrimos.Enabled = false;
                        lblError.Text = "¡Error!\n\n" + txtNumeroUsuario.Text + " no es un número entero correcto\n\n El número introducido no puede contener caracteres no numéricos";
                    }
                }
                else
                {
                    if (iNumUsuario <= 0)
                    {
                        btnNumerosPrimos.Enabled = false;
                        lblError.Text = "¡Error!\n\nEl número introducido ha de ser un número positivo mayor que 0";
                    }
                    else
                    {
                        btnNumerosPrimos.Enabled = true;
                        lblError.Text = "";
                    }
                }
            }
        }
    }
}
