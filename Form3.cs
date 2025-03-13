using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double baseRetangulo) &&
               double.TryParse(textBox3.Text, out double altura))
            {

                double perimetro = 2 * (baseRetangulo + altura);
                label9.Text = $"Perímetro: {perimetro}";

                double area = baseRetangulo * altura;
                label8.Text = $"Área: {area}";



                double profundidade = altura;
                double volume = baseRetangulo * altura * profundidade;
                label7.Text = $"Volume: {volume}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para a base e a altura.");
            }
        }
    }
}
