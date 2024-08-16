namespace calculadoraCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            float valor1, valor2, total = 0;

            if (cboOperacao.SelectedIndex != 0)
            {
                valor1 = float.Parse(txtValor1.Text);
                valor2 = float.Parse(txtValor2.Text);

                if (cboOperacao.SelectedIndex == 1)
                {
                    total = valor1 + valor2;
                }
                else if (cboOperacao.SelectedIndex == 2)
                {
                    total = valor1 - valor2;
                }
                else if (cboOperacao.SelectedIndex == 3)
                {
                    total = valor1 * valor2;
                }
                else
                {
                    total = valor1 / valor2;
                }
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOperacao.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abrirForm2 = new Form2();

            this.Hide(); // esconde o formulário atual

            abrirForm2.Show();
        }
    }
}
