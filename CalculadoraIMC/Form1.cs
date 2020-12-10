using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            decimal Peso = Convert.ToDecimal(txtPeso.Text.Trim());
            decimal Altura = Convert.ToDecimal(txtAltura.Text.Trim());

            decimal ResultadoIMC = Peso / (Altura * Altura);
            
             

                if(ResultadoIMC >=18 && ResultadoIMC <24)
                {
                    MessageBox.Show("Você está na medida!");
                }
                if(ResultadoIMC >=24 && ResultadoIMC <29)
                {
                    MessageBox.Show("Sobrepeso!");
                }
                if(ResultadoIMC >=29 && ResultadoIMC < 40)
                {
                    MessageBox.Show("Obesidade!");
                }
                else if (ResultadoIMC >=40)
                {
                    MessageBox.Show("Obesidade grave!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, contate Administrador");
            }

        }
    }
}
