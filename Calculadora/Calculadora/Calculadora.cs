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
        ClaseCalculadora calculadora = new ClaseCalculadora();
        ClassRecibirNumeros Captura = new ClassRecibirNumeros();

        public int xClick = 0, yClick = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        #region Funciones

        private void labelSalir_Click(object sender, EventArgs e)
        {
            Respuesta.RespuestaSalir();
        }
        #endregion

       


        #region CapturarNumeros

        

       

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text = textBoxResultados.Text + Captura.CapturarNumeros(buttonN1.Text);
        }

        private void buttonN0_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text = textBoxResultados.Text + Captura.CapturarNumeros(buttonN0.Text);
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {



        }

        private void buttonN7_Click(object sender, EventArgs e)
        {

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
