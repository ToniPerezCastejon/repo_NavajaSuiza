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
        /// Evento que recoge un valor aleatorio de tipo entero, y lanza el método <see cref="JugarRandom(int)"/>
        /// </summary>
        /// <remarks> El valor aleatorio es obtenido mediante el uso de la clase <see cref="Random"/> </remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnJuegoAdivinarNumero_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int iNumero = rdm.Next(0, 100);


            JugarRandom(iNumero);
        }

        /// <summary>
        /// Método que llama a la clase <see cref="InputBoxDialog"/> 
        /// </summary>
        /// <param name="texto"> El texto introducido por el usuario en la interfaz del InputBox</param>
        /// <returns> Valor de tipo string </returns>
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;


            ib.Close();

            return s;
        }

        /// <summary>
        /// Método que pide al usuario que introduzca números enteros, de forma sucesiva, para tratar de adivinar un número aleatorio
        /// </summary>
        /// <remarks> El usuario tiene un máximo de 6 intentos para adivinar el número </remarks>
        /// <remarks> Para pedir los números al usuario, se lanza el método <see cref="InputBox(string)"/> </remarks>
        /// <remarks> 
        /// Por cada intento fallido, el sistema muestra un mensaje al usuario, mediante <see cref="MessageBox"/>,
        /// si el último número introducido es mayor o menor que <paramref name="iNumeroRandom"/>  
        /// </remarks>
        /// <param name="iNumeroRandom"> Número aleatorio que debe adivinar el usuario</param>
        void JugarRandom(int iNumeroRandom)
        {
            int iNumeroUsuario;
            int iIntentos = 6;
            bool bCorrecto;
            string sNumerosProbados = "Números probados: ";


            do
            {
                bCorrecto = int.TryParse(InputBox("Introduzca un número entero comprendido entre 0 y 100"), out iNumeroUsuario);

                if(!bCorrecto)
                {
                    MessageBox.Show("¡Error!\n\nEl valor introducido no es un número entero");
                }
                else
                {
                    if (iNumeroUsuario == iNumeroRandom)
                    {
                        MessageBox.Show("¡Enhorabuena! Has acertado el número " + iNumeroRandom);
                    }
                    else
                    {
                        if (iNumeroUsuario < iNumeroRandom)
                        {
                            sNumerosProbados = sNumerosProbados + iNumeroUsuario + ", ";
                            lblNumerosProbados.Text = sNumerosProbados;
                            iIntentos--;
                            MessageBox.Show("El número introducido (" + iNumeroUsuario + ") es MENOR que el número secreto\n Te quedan " + iIntentos + " intentos");
                        }
                        else
                        {
                            sNumerosProbados = sNumerosProbados + iNumeroUsuario + ", ";
                            lblNumerosProbados.Text = sNumerosProbados;
                            iIntentos--;
                            MessageBox.Show("El número introducido (" + iNumeroUsuario + ") es MAYOR que el número secreto\n Te quedan " + iIntentos + " intentos");
                        }
                    }
                }
            }
            while (iNumeroUsuario != iNumeroRandom && iIntentos > 0);

            if (iNumeroUsuario != iNumeroRandom)
            {
                MessageBox.Show("¡Has perdido! ¡LOOSER!\nEl número era: " + iNumeroRandom);
            }
        }
    }
}
