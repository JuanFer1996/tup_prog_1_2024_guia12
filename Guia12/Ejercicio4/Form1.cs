using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        double[] valores = new double[5];
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            lsbListado.Items.Clear();

            Form2 fDialog = new Form2();

            while (contador < 5 && fDialog.ShowDialog() == DialogResult.OK)
            {
                valores[contador] = Convert.ToDouble(fDialog.tbValor.Text);
                contador++;
               
                fDialog.tbValor.Clear();


            }
            for (int i = 0; i < contador; i++)
            {
                lsbListado.Items.Add(valores[i]);
            }

            lbCantidad.Text=$"{contador}";
            
        }
    }
}