using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculadora.ModeloCalculadora
{
    public class ClaseCalculadora
    {
        #region Propiedades

        private double numero1;

        private double numero2;

        #endregion


        #region Atributos

        public double Numero1
        {
            get
            {
                return this.numero1;
            }
            set
            {
                if (numero1 < 0)
                {
                    value = 0;
                }

                else
                {
                    this.numero1 = value;
                }
            }
        }

        public double Numero2
        {
            get
            {
                return this.numero2;
            }

            set
            {
                if (numero2 < 0)
                {
                    value = 0;
                }

                else
                {
                    this.numero2 = value;
                }
            }
        }


        #endregion


        #region Funciones

        public double Suma(double n1,double n2)
        {
            double r = 0;

            r = n1 + n2;

            return r;
        }

        #endregion

    }
}
