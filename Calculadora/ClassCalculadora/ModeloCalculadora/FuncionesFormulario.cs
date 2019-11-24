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

namespace ClassCalculadora.ModeloCalculadora
{
    public class FuncionesFormulario
    {
        DialogResult Respuesta = new DialogResult();
        public void RespuestaSalir()
        {
            Respuesta = MessageBox.Show("Desea salir", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Respuesta==DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                return;
            }
        }

        


    }
}
