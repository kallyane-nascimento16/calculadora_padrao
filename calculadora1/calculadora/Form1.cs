using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0 ,valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
             valor2 = decimal.Parse (resultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")
            {
                resultado.Text = Convert.ToString (valor1 + valor2);

            }
            else if (operacao == "subtracao")
            {

                resultado.Text = Convert.ToString(valor1 - valor2);

            }
            else if (operacao == "divizao")
            {

                resultado.Text = Convert.ToString(valor1 / valor2);

            }
            else if (operacao == "mutiplicacao")
            {
                resultado.Text = Convert.ToString(valor1 * valor2);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                valor1 = decimal.Parse(resultado.Text, CultureInfo.InstalledUICulture);
                resultado.Text = "";
                operacao = "subtracao";

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                valor1 = decimal.Parse(resultado.Text, CultureInfo.InstalledUICulture);
                resultado.Text = "";
                operacao = "mutiplicacao";

            }
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                valor1 = decimal.Parse(resultado.Text, CultureInfo.InstalledUICulture);
                resultado.Text = "";
                operacao = "divizao";


            }
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (resultado.Text  != "" )
            {
                valor1 = decimal.Parse(resultado.Text, CultureInfo.InstalledUICulture);
                resultado.Text = "";
                operacao = "soma";

            }
            
           
            
          
       
        }
    }
}
