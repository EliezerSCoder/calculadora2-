using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double lado))
            {
                // Calcula o perímetro
                double perimetro = 4 * lado;
                label4.Text = $"Perímetro: {perimetro}";

                // Calcula a área
                double area = lado * lado;
                label5.Text = $"Área: {area}";

                
                double volume = lado * lado * lado;
                label6.Text = $"Volume: {volume}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para o lado do quadrado.");
            }
        }

        private void Retangulo1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            this.Hide();
        }
    }
}
