using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            suma.N1 = Int32.Parse(txtn1.Text);
            suma.N2 = Int32.Parse(txtn2.Text);
            MessageBox.Show("El resultado de la suma " + suma.N1 + " + " + suma.N2 + " es: " + suma.calcular());
        }

        private void btnResta_Click(object sender, EventArgs e)
        {

            Resta resta = new Resta();
            resta.N1 = Int32.Parse(txtn1.Text);
            resta.N2 = Int32.Parse(txtn2.Text);
            MessageBox.Show("El resultado de la resta " + resta.N1 + " - " + resta.N2 + " es: " + resta.calcular());
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

            Multiplicacion multiplicacion = new Multiplicacion();
            multiplicacion.N1 = Int32.Parse(txtn1.Text);
            multiplicacion.N2 = Int32.Parse(txtn2.Text);
            MessageBox.Show("El resultado de la multiplicacion " + multiplicacion.N1 + " * " + multiplicacion.N2 + " es: " + multiplicacion.calcular());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            Division division = new Division();
            division.N1 = Int32.Parse(txtn1.Text);
            division.N2 = Int32.Parse(txtn2.Text);
            MessageBox.Show("El resultado de la division " + division.N1 + " / " + division.N2 + " es: " + division.calcular());

        }
    }
}
