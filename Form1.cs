namespace calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = 0;

                if (radioButton1.Checked)
                {
                    resultado = num1 + num2;

                }
                else if (radioButton2.Checked)
                {
                    resultado = num1 - num2;
                }
                else if (radioButton3.Checked)
                {
                    resultado = num1 * num2;
                }
                else if (radioButton4.Checked)
                {
                    resultado = num1 / num2;

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma operação.");
                    return;
                }



                Resultado.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Hide();

        }
    }
}
