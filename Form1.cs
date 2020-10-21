using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUnidimensionalG4
{
    public partial class Form1 : Form
    {
        Matriz miMatriz;
        int indice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefinirTamaño_Click(object sender, EventArgs e)
        {
            indice = 0;
            int n = int.Parse(txtbTotalElementos.Text);
            miMatriz = new Matriz(n);
        }

        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            float elemento = 0;
            if( chkbAleatorio.Checked)
            {
                Random aleatorio = new Random();
                elemento = Convert.ToSingle(aleatorio.NextDouble())*1000;
            }
            else
            {
                elemento = float.Parse(txtbElemento.Text);
            }
             
            miMatriz.Agregar(elemento, indice++);
            lbMatriz.Text = miMatriz.ToString();

        }
    }
}
