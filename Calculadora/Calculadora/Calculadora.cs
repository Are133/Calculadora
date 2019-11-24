using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalculadora.ModeloCalculadora;

namespace Calculadora
{
    
    public partial class Calculadora : Form
    {
        FuncionesFormulario Respuesta = new FuncionesFormulario();
       

        double primernumero, segundonumero,resultado    ;
        string operacion;


        public int xClick = 0, yClick = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        #region FuncionesForm

        private void labelSalir_Click(object sender, EventArgs e)
        {
            Respuesta.RespuestaSalir();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {

                textBoxResultados.Text = textBoxResultados.Text.Substring(0, textBoxResultados.Text.Count() - 1);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {
                textBoxResultados.Clear();
            }
        }
        #endregion




        #region CapturarNumeros

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += ".";
        }

        private void buttonN0_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "0";
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "1";
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "2";
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "3";
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "4";
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "5";
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "6";
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "7";
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "8";
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text += "9";
        }










        #endregion


        

        #region Funciones

        private void buttonPorcentaje_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {
                operacion = "%";
                primernumero = double.Parse(textBoxResultados.Text);
                textBoxResultados.Clear();
            }
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if(textBoxResultados.Text==string.Empty)
            {
                return;
            }

            else
            {
                operacion = "-";
                primernumero = double.Parse(textBoxResultados.Text);
                textBoxResultados.Clear();
                
            }
            
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {
                operacion = "+";
                primernumero = double.Parse(textBoxResultados.Text);
                textBoxResultados.Clear();
            }
            
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            segundonumero = double.Parse(textBoxResultados.Text);

            if (operacion == "+")
            {
                resultado = primernumero + segundonumero;
                textBoxResultados.Text = resultado.ToString();
            }

            if(operacion=="-")
            {
                resultado = primernumero - segundonumero;
                textBoxResultados.Text = resultado.ToString();
            }

            if (operacion == "*")
            {
                if (primernumero < 0)
                {
                    resultado = primernumero * segundonumero;
                    resultado = 0;
                    textBoxResultados.Text = resultado.ToString();
                    errorProvider1.SetError(textBoxResultados, "No hay productos negativos");
                    return;
                }
                errorProvider1.Clear();

                if (segundonumero < 0)
                {
                    resultado = primernumero * segundonumero;
                    resultado = 0;
                    textBoxResultados.Text = resultado.ToString();
                    errorProvider1.SetError(textBoxResultados, "No hay productos negativos");
                    return;
                }
                errorProvider1.Clear();

              
                resultado = primernumero * segundonumero;

                textBoxResultados.Text = resultado.ToString();
                
            }

            if (operacion == "/")
            {
                if(primernumero<0 && segundonumero < 0)
                {
                    errorProvider1.SetError(textBoxResultados, "No hay divisiones negativas");
                    resultado = 0;
                    textBoxResultados.Text = resultado.ToString();
                    return;
                }
                errorProvider1.Clear();

                resultado = primernumero / segundonumero;
                textBoxResultados.Text = resultado.ToString();
                
            }

            if (operacion == "%")
            {
                if (primernumero > segundonumero)
                {
                    errorProvider1.SetError(textBoxResultados,"El porcentaje es mayor ala cantidad");
                    resultado = 0;
                    textBoxResultados.Text = resultado.ToString();
                    return;
                    
                }
                errorProvider1.Clear();

                primernumero = primernumero * segundonumero;
                primernumero = primernumero / 100;

                resultado = primernumero;

                textBoxResultados.Text = resultado.ToString();

                
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {
                operacion = "*";
                primernumero = double.Parse(textBoxResultados.Text);
                textBoxResultados.Clear();
            }
            
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBoxResultados.Text == string.Empty)
            {
                return;
            }

            else
            {
                operacion = "/";
                primernumero = double.Parse(textBoxResultados.Text);
                textBoxResultados.Clear();
            }
        }


        #endregion

        #region Eventos


        private void Calculadora_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button != MouseButtons.Left))
            {
                xClick = e.X;
                yClick = e.Y;
            }

            else
            {
                this.Left = this.Left + (e.X - xClick);
                this.Top =this.Top + (e.Y - yClick);
            }
        }

        #endregion



    }
}
