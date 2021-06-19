using FormPrincipal.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtNumero1.Text);
            double num2 = Double.Parse(txtNumero2.Text);

            calculator.a = num1;
            calculator.b = num2;

            double suma = calculator.Suma();
            double resta = calculator.Resta();
            double multiplicacion = calculator.Multiplicacion();
            double division = calculator.Division();
            double potencia = calculator.Potencia();
            double raiz = calculator.Raiz();

            txtSuma.Text = Convert.ToString(suma);
            txtResta.Text = Convert.ToString(resta);
            txtMultiplicacion.Text = Convert.ToString(multiplicacion);

            txtPotencia.Text = Convert.ToString(potencia);

            if (division == 0)
            {
                txtDivision.Text = "ERROR";
                txtRaiz.Text = "ERROR";
            }
            else
            {
                txtDivision.Text = Convert.ToString(division);
                txtRaiz.Text = Convert.ToString(raiz);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
      /*  txtNumero1.Text = "";
            txtNumero2.Text = "";

            txtSuma.Text = "";
            txtResta.Text = "";
            txtMultiplicacion.Text = "";
            txtDivision.Text = "";
            txtPotencia.Text = "";
            txtRaiz.Text = ""; */

            txtNumero1.Clear();
            txtNumero2.Clear();
            txtSuma.Clear();
            txtResta.Clear();
            txtMultiplicacion.Clear();
            txtDivision.Clear();
            txtPotencia.Clear();
            txtRaiz.Clear();
        }
    }
}
