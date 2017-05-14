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
///  Espacio de nombres para la aplicación <see cref="NavajaSuiza.Aplicación_3_JuegoAdivinarNumero"/>
/// </summary>
namespace NavajaSuiza.Aplicación_3_JuegoAdivinarNumero
{
    /// <summary>
    /// Clase pública parcial <see cref="frmJuegoAdivinarNumero"/> de tipo <see cref="Form"/>
    /// </summary>
    public partial class frmJuegoAdivinarNumero : Form
    {
        /// <summary>
        ///  Constructor del formulario <see cref="frmJuegoAdivinarNumero"/>
        /// </summary>
        public frmJuegoAdivinarNumero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Declaración de la instancia <see cref="oAdivinarNum"/> , perteneciente a la clase <see cref="AdivinarNúmeroLógica"/> 
        /// </summary>
        AdivinarNúmeroLógica oAdivinarNum;

        /// <summary>
        /// Evento que inicializa la instancia <see cref="oAdivinarNum"/> y le asigna un valor aleatorio de tipo entero 
        /// </summary>
        /// <remarks> El valor aleatorio es obtenido mediante el uso de la clase <see cref="Random"/> </remarks>
        /// <remarks> El botón <see cref="btnJuegoAdivinarNumero"/> se desactiva hasta que termina el juego actual</remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnJuegoAdivinarNumero_Click(object sender, EventArgs e)
        {
            Random oRdm = new Random();
            oAdivinarNum = new AdivinarNúmeroLógica();
            int iNumeroRandom = oRdm.Next(0, 100);

            lblNumerosProbados.Text = "";
            txtNumUsuario.Text = "";
            oAdivinarNum.NumAleatorio = iNumeroRandom;

            btnJuegoAdivinarNumero.Enabled = false;
        }


        /// <summary>
        /// Evento que recoge un valor aleatorio de tipo entero, 
        /// y lanza el método <see cref="AdivinarNúmeroLógica.JugarRandom(int, out int, out int)"/>:
        /// recibe:
        /// iNumeroUsuario <see cref="int"/>, introducido por el usuario, y lo compara con el miembro <see cref="AdivinarNúmeroLógica.mNumAleatorio"/>,
        /// devuelve: 
        /// iCompareNums <see cref="int"/>, para indicar si el número introducido es igual (0), menor (-1) o mayor (1) que <see cref="AdivinarNúmeroLógica.mNumAleatorio"/>
        /// iIntentosRestantes <see cref="int"/>, para indicar <see cref="AdivinarNúmeroLógica.mIntentosRestantes"/>
        /// el string SNumerosProbados, para mostrar al usuario todos los números utilizados en cada uno de los intentos
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnProbarNum_Click(object sender, EventArgs e)
        {
            int iNumeroUsuario;
            int iCompareNums;
            int iIntentosRestantes;
            bool bNumCorrecto;

            bNumCorrecto = int.TryParse(txtNumUsuario.Text, out iNumeroUsuario);

            if (bNumCorrecto)
            {
                try
                {
                    oAdivinarNum.JugarRandom(iNumeroUsuario, out iCompareNums, out iIntentosRestantes);
                    lblNumerosProbados.Text = "Números probados: " + oAdivinarNum.NumerosUsados();

                    if (iCompareNums == 0)
                    {
                        MessageBox.Show("¡ENHORABUENA! ¡HAS GANADO!");
                        btnProbarNum.Enabled = false;
                        btnJuegoAdivinarNumero.Enabled = true;
                        txtNumUsuario.Text = "";
                    }
                    else
                    {
                        if (oAdivinarNum.IntentosRestantes > 0)
                        {
                            if (iCompareNums > 0)
                            {
                                //MessageBox.Show(sPista);
                                MessageBox.Show("El número introducido (" + iNumeroUsuario + ") es MAYOR que el número secreto\n Te quedan " + iIntentosRestantes + " intentos");
                                txtNumUsuario.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("El número introducido (" + iNumeroUsuario + ") es MENOR que el número secreto\n Te quedan " + iIntentosRestantes + " intentos");
                                txtNumUsuario.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡HAS PERDIDO! ¡LOOSER!\nEl número era: " + oAdivinarNum.NumAleatorio);
                            btnProbarNum.Enabled = false;
                            btnJuegoAdivinarNumero.Enabled = true;
                            txtNumUsuario.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error:" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox <see cref="txtNumUsuario"/>
        /// </summary>
        /// <remarks> Activa o desactiva el botón <see cref="btnProbarNum"/> en función del valor de <see cref="txtNumUsuario"/></remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Instancia que contiene los datos del evento <see cref="EventArgs"/></param>
        private void txtNumUsuario_TextChanged(object sender, EventArgs e)
        {
            int iNumUsuario;
            bool bCorrecto;

            if (!btnJuegoAdivinarNumero.Enabled)
            {
                if (String.IsNullOrWhiteSpace(txtNumUsuario.Text))
                {
                    btnProbarNum.Enabled = false;
                    lblError.Text = "";
                }
                else
                {
                    bCorrecto = int.TryParse(txtNumUsuario.Text, out iNumUsuario);

                    if (!bCorrecto)
                    {
                        long lngNumero;
                        bCorrecto = long.TryParse(txtNumUsuario.Text, out lngNumero);

                        if (bCorrecto)
                        {
                            if (lngNumero > Int32.MaxValue)
                            {
                                btnProbarNum.Enabled = false;
                                lblError.Text = "¡Error!\n\n" + txtNumUsuario.Text + " no es un número entero correcto\n\n El número introducido debe ser menor que " + Int32.MaxValue;
                            }
                            else
                            {
                                if (lngNumero < Int32.MinValue)
                                {
                                    btnProbarNum.Enabled = false;
                                    lblError.Text = "¡Error!\n\n" + txtNumUsuario.Text + " no es un número entero correcto\n\n El número introducido debe ser un número positivo mayor que 0";
                                }
                            }
                        }
                        else
                        {
                            btnProbarNum.Enabled = false;
                            lblError.Text = "¡Error!\n\n" + txtNumUsuario.Text + " no es un número entero correcto\n\n El número introducido no puede contener caracteres no numéricos";
                        }
                    }
                    else
                    {
                        if (iNumUsuario < 0 || iNumUsuario > 100)
                        {
                            btnProbarNum.Enabled = false;
                            lblError.Text = "¡Error!\n\nEl número introducido ha de estar comprendido en el rango [0-100]";
                        }
                        else
                        {
                            btnProbarNum.Enabled = true;
                            lblError.Text = "";
                        }
                    }
                }
            }
            else
            {
                btnProbarNum.Enabled = false;
            }
        }
    }
}
