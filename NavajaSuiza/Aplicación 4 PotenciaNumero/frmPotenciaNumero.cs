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
        /// Evento que recoge mediante TextBox dos números enteros -una base y un exponente- y lanza el método <see cref="PotenciaLógica.CalcularPotencia(int, int)"/> 
        /// para calcular la potencia
        /// </summary>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnPotenciaNumero_Click(object sender, EventArgs e)
        {
            int iBase;
            int iExponente;
            double dResultado;

            iBase = int.Parse(txtBase.Text);
            iExponente = int.Parse(txtExponente.Text);

            try
            {
                dResultado = PotenciaLógica.CalcularPotencia(iBase, iExponente);
                MessageBox.Show(dResultado.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error:" + ex.Message);
            }
        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox <see cref="txtBase"/>
        /// </summary>
        /// <remarks> El TextBox <see cref="txtExponente"/> también está ligado y activa este evento TextChanged</remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Instancia que contiene los datos del evento <see cref="EventArgs"/></param>
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            int iBase;
            int iExponente;
            bool bBaseCorrecta;
            bool bExpCorrecto;

            if (String.IsNullOrWhiteSpace(txtBase.Text) || String.IsNullOrWhiteSpace(txtExponente.Text))
            {
                btnPotenciaNumero.Enabled = false;
                lblErrorBase.Text = "";
                lblErrorExp.Text = "";
            }
            else
            {
                bBaseCorrecta = int.TryParse(txtBase.Text, out iBase);
                bExpCorrecto = int.TryParse(txtExponente.Text, out iExponente);

                if (!bBaseCorrecta || !bExpCorrecto)
                {
                    long lngBase;
                    long lngExp;
                    bBaseCorrecta = long.TryParse(txtBase.Text, out lngBase);
                    bExpCorrecto = long.TryParse(txtExponente.Text, out lngExp);

                    if (bBaseCorrecta)
                    {
                        if (lngBase > Int32.MaxValue)
                        {
                            btnPotenciaNumero.Enabled = false; 
                            lblErrorBase.Text = "La base introducida debe ser menor que " + Int32.MaxValue;
                        }
                        else
                        {
                            if (lngBase < Int32.MinValue)
                            {
                                btnPotenciaNumero.Enabled = false;                               
                                lblErrorBase.Text = "La base introducida debe ser mayor que " + Int32.MinValue;
                            }
                            else
                            {
                                lblErrorBase.Text = "";
                            }
                        }
                    }
                    else
                    {
                        btnPotenciaNumero.Enabled = false;                        
                        lblErrorBase.Text = "La base introducida no puede contener caracteres no numéricos";
                    }

                    if (bExpCorrecto)
                    {
                        if (lngExp > Int32.MaxValue)
                        {
                            btnPotenciaNumero.Enabled = false;                           
                            lblErrorExp.Text = "El exponente introducido debe ser menor que " + Int32.MaxValue;
                        }
                        else
                        {
                            if (lngExp < Int32.MinValue)
                            {
                                btnPotenciaNumero.Enabled = false;
                                lblErrorExp.Text = "El exponente introducido debe ser menor que " + Int32.MinValue;
                            }
                            else
                            {
                                lblErrorExp.Text = "";
                            }
                        }
                    }
                    else
                    {
                        btnPotenciaNumero.Enabled = false;                        
                        lblErrorExp.Text = "El exponente introducido no puede contener caracteres no numéricos";
                    }
                }
                else
                {
                    btnPotenciaNumero.Enabled = true;
                    lblErrorExp.Text = "";
                    lblErrorBase.Text = "";
                }
            }
        }
    }
}
