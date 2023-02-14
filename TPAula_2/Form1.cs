using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//        Celsius/Fahrenheit 0
//Fahrenheit/Celsius 1

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Faremheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.opcoes.SelectedIndex == 0)
            {
                float celsius = 0;
                if (float.TryParse(this.Celsiuu.Text, out celsius))
                {
                    float far = (float)(celsius * 9 / 5) + 32;
                    Faremheit.Text = $"{far:N2}";
                }
                else
                {
                    MessageBox.Show("Valor invalido");
                    Faremheit.Text = "";
                }
            }
            else if (this.opcoes.SelectedIndex == 1)
            {
                float far2 = 0;
                if (float.TryParse(this.Celsiuu.Text, out far2))
                {
                    float cel2 = (float)((far2 - 32) * 5 / 9);
                    Faremheit.Text = $"{cel2:N2}";
                }
                else
                {
                    MessageBox.Show("Valor invalido");
                    Faremheit.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Selecione o tipo de conversão");
                Faremheit.Text = "";
            }
        }
    }
}
