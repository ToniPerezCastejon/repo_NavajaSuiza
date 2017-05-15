using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NavajaSuiza.Aplicación_2_ValidarFecha
{
    /// <summary>
    /// Clase <see cref="FechaLógica"/> 
    /// </summary>
    public class FechaLógica
    {
        private int mDia;
        private int mMes;
        private int mAnyo;

        /// <summary>
        /// Propiedad <see cref="Dia"/> 
        /// </summary>
        /// <value> Variable de tipo entero, correspondiente al día, cuyo valor está comprendido en el rango 1-31</value>
        public int Dia
        {
            get { return mDia; }
            set { mDia = value; }
        }

        /// <summary>
        /// Propiedad <see cref="Mes"/> 
        /// </summary>
        /// <value> Variable de tipo entero, correspondiente al mes, cuyo valor está comprendido en el rango 1-12</value>
        public int Mes
        {
            get { return mMes; }
            set { mMes = value; }
        }

        /// <summary>
        /// Propiedad <see cref="Anyo"/> 
        /// </summary>
        /// <value> Variable de tipo entero, correspondiente al año</value>
        public int Anyo
        {
            get { return mAnyo; }
            set { mAnyo = value; }
        }


        /// <summary>
        /// Método que recoge tres miembros <see cref="mDia"/>, <see cref="mMes"/> y <see cref="mAnyo"/>,
        /// correspondientes a una fecha, y determina si dicha fecha es válida o no
        /// </summary>
        /// <remarks> El método tiene en cuenta que los distintos meses pueden tener 28/29, 30 o 31 días </remarks>
        /// <remarks> 
        /// Lanza el método <see cref="ComprobarBisiesto()"/> que devuelve un booleano indicando si el año es bisiesto y,
        /// con dicho booleano, el método actual determina si el mes de febrero tiene 28 días (no bisiesto) o 29 días (bisiesto)
        /// </remarks>
        /// <returns> Booleano que indica si la fecha es válida o no </returns>
        public bool ValidarFecha()
        {
            bool bFechaValida = true;
            bool bBisiesto = false;


            if (mDia < 1 || mDia > 31 || mMes < 1 || mMes > 12)
            {
                bFechaValida = false;
            }
            else
            {
                switch (mMes)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (mDia > 30)
                        {
                            bFechaValida = false;
                        }
                        break;
                    case 2:
                        bBisiesto = ComprobarBisiesto();
                        if (bBisiesto == false && mDia > 28)
                        {
                            bFechaValida = false;
                        }
                        if (bBisiesto == true && mDia > 29)
                        {
                            bFechaValida = false;
                        }
                        break;
                }
            }

            return bFechaValida;
        }

        /// <summary>
        /// Método que determina si el valor del miembro <see cref="mAnyo"/> corresponde a un año bisiesto o no, devolviendo un booleano
        /// </summary>
        /// <returns> Booleano que indica si el año es bisiesto o no </returns>
        bool ComprobarBisiesto()
        {
            bool bBisiesto = false;

            if (mAnyo % 4 == 0)
            {
                bBisiesto = true;
                if (mAnyo % 100 == 0 && mAnyo % 400 != 0)
                {
                    bBisiesto = false;
                }
            }

            return bBisiesto;
        }


        /// <summary>
        /// Constructor de la clase <see cref="FechaLógica"/> 
        /// </summary>
        /// <remarks>
        /// Contiene los miembros <see cref="mDia"/>, <see cref="mMes"/> y <see cref="mAnyo"/> 
        /// </remarks>
        public FechaLógica()
        {
            mDia = 0;
            mMes = 0;
            mAnyo = 0;
        }
    }
}

