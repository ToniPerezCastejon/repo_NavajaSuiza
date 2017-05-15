using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        /// Evento que recoge una fecha, y lanza el método <see cref="FechaLógica.ValidarFecha()"/> para comprobar si dicha fecha es válida
        /// </summary>
        /// <remarks>
        /// La fecha se desglosa en tres variables de tipo entero, recogidas mediante textbox, que se corresponden con el día, mes y año
        /// </remarks>
        /// <remarks>
        /// El booleano recibido por el método <see cref="FechaLógica()"/> determina si la fecha introducida por el usuario es válida o no
        /// </remarks>
        /// <param name="sender"> Parámetro de tipo object</param>
        /// <param name="e"> Parámetro de la clase <see cref="EventArgs"/> </param>
        private void btnValidarFecha_Click(object sender, EventArgs e)
        {
            bool bDia;
            bool bMes;
            bool bAnyo;
            int iDia;
            int iMes;
            int iAnyo;
            bool bFechaValida = true;
            FechaLógica oFecha;


            bDia = int.TryParse((txtDia.Text), out iDia);
            bMes = int.TryParse((txtMes.Text), out iMes);
            bAnyo = int.TryParse((txtAnyo.Text), out iAnyo);

            if (bDia && bMes && bAnyo)
            {
                try
                {
                    oFecha = new FechaLógica();

                    oFecha.Dia = iDia;
                    oFecha.Mes = iMes;
                    oFecha.Anyo = iAnyo;

                    bFechaValida = oFecha.ValidarFecha();

                    if (bFechaValida == true)
                    {
                        MessageBox.Show("La fecha introducida es válida");
                    }
                    else
                    {
                        MessageBox.Show("La fecha introducida NO es válida");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error:" + ex.Message);
                }
            }

        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox <see cref="txtDia"/>
        /// </summary>
        /// <remarks> Los TextBox <see cref="txtMes"/> y <see cref="txtAnyo"/> también están ligados y activan este evento TextChanged </remarks>
        /// <param name="sender"> Parámetro de tipo object </param>
        /// <param name="e"> Instancia que contiene los datos del evento  <see cref="EventArgs"/> </param>
        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            bool bDiaCorrecto;
            bool bMesCorrecto;
            bool bAnyoCorrecto;
            int iDia, iMes, iAnyo;

            if (String.IsNullOrWhiteSpace(txtDia.Text) || String.IsNullOrWhiteSpace(txtMes.Text) || String.IsNullOrWhiteSpace(txtAnyo.Text))
            {
                btnValidarFecha.Enabled = false;
                lblError.Text = "";
            }
            else
            {
                bDiaCorrecto = int.TryParse(txtDia.Text, out iDia);
                bMesCorrecto = int.TryParse(txtMes.Text, out iMes);
                bAnyoCorrecto = int.TryParse(txtAnyo.Text, out iAnyo);

                if (!bDiaCorrecto || !bMesCorrecto || !bAnyoCorrecto)
                {
                    btnValidarFecha.Enabled = false;
                    lblError.Text = "¡Error! Ninguno de los datos introducidos puede contener caracteres que no sean numéricos";
                }
                else
                {
                    if (iDia < 1 || iDia > 31 || iMes < 1 || iMes > 12)
                    {
                        btnValidarFecha.Enabled = false;
                        lblError.Text = "¡Error! Los datos introducidos deben estar dentro de los siguientes rangos:\n\nDía [1-31]\n\nMes [1-12]";

                    }
                    else
                    {
                        btnValidarFecha.Enabled = true;
                        lblError.Text = "";
                    }
                }
            }
        }
    }
}