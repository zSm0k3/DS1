namespace CalcVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboPagto_SelectedIndexChanged(object sender, EventArgs e)
        {
            double preco, total, parcela;
            int qtde;

            if (cboPagto.SelectedIndex != 0)
            {
                preco = double.Parse(txtPreco.Text);
                qtde = int.Parse(txtQtde.Text);

                if (cboPagto.SelectedIndex == 1)
                {
                    parcela = (preco * qtde * 1.1) / 2;
                    total = parcela * 2;
                }
                else if (cboPagto.SelectedIndex == 2)
                {
                    total = preco * qtde;
                }
                else if (cboPagto.SelectedIndex == 3)
                {
                    total = preco * qtde * 0.9;
                }
                else
                {
                    total = preco * qtde * 0.9;
                }
                
                lblTotal.Text = total.ToString();
            }
            else
            {
                lblTotal.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPagto.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (resposta == DialogResult.Yes) 
            {
                Application.Exit();
            }
        
        }
    }
}
