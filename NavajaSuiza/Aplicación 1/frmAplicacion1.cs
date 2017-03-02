using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_1
{
    public partial class frmAplicacion1 : Form
    {
        /// <summary>
        /// crea una variable de tipo aplicacion1 y la instancia para uso posterior
        /// </summary>
        Aplicacion1 oAplicacion1=new Aplicacion1();

        public frmAplicacion1()
        {
            InitializeComponent();
        }




        /// <summary>
        /// evento que lanza un método de la clase aplicación1
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(oAplicacion1.Metodo());
        }
    }
}
