using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculadora.ModeloCalculadora
{
    public class ClassCapturarFunciones
    {
        public string CapturarFunciones(string funciones)
        {
            if (funciones == "*")
            {
                return "*";
            }

            if (funciones == "/")
            {
                return "/";
            }

            if (funciones == "-")
            {
                return "-";
            }

            if (funciones == "+")
            {
                return "+";
            }

            if (funciones == "%")
            {
                return "%";
            }

            else
            {
                return "";
            }
        }



    }
}
