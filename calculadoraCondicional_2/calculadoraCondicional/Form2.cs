using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraCondicional
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCargo.SelectedIndex = 0;
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxNovoSalario.Text = "";
            textBoxSalario.Text = "";
            comboBoxCargo.SelectedIndex = 0;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor1, total = 0;

            if (comboBoxCargo.SelectedIndex != 0)
            {
                valor1 = double.Parse(textBoxSalario.Text);

                if (comboBoxCargo.SelectedIndex == 1)
                {
                    total = valor1 * 1.05;
                }
                else if (comboBoxCargo.SelectedIndex == 2)
                {
                    total = valor1 * 1.07;
                }
                else if (comboBoxCargo.SelectedIndex == 3)
                {
                    total = valor1 * 1.1;
                }
                else
                {
                    total = valor1 * 1.08;
                }
                textBoxNovoSalario.Text = total.ToString();
            }
            else
            {
                textBoxNovoSalario.Text = "";
            }
        }
    }
}
