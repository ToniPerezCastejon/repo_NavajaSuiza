using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// llama a una aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            Aplicación_1_NumerosPrimos.frmNumerosPrimos oFormulario = new Aplicación_1_NumerosPrimos.frmNumerosPrimos();
            oFormulario.ShowDialog();

            
         }
    }
}
