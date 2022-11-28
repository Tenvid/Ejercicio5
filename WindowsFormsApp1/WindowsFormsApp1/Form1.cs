using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            int numEspacio = 1;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            for (int i = 0; i < numPalabras; i++)
            {
                if (textoTelegrama[i] == ' ')
                    numEspacio++;
            }
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numEspacio <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numEspacio - 10);
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numEspacio <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numEspacio - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
