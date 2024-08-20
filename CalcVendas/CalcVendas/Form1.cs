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
            double preco, total = 0, parcela;
            int qtde;

            if (cboPagto.SelectedIndex != 0)
            {
                preco = double.Parse(txtPreco.Text);
                qtde = int.Parse(txtQtde.Text);
                picturePagto.Visible = true;

                if (cboPagto.SelectedIndex == 1)
                {
                    parcela = (preco * qtde * 1.1) / 2;
                    total = parcela * 2;
                    MessageBox.Show($"O valor da parcela é de {parcela:c}", "Valor Parcela", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picturePagto.Image = Properties.Resources.cartao;
                }
                else if (cboPagto.SelectedIndex == 2)
                {
                    total = preco * qtde;
                    picturePagto.Image = Properties.Resources.cartao;
                }
                else if (cboPagto.SelectedIndex == 3 || cboPagto.SelectedIndex == 4)
                {
                    total = preco * qtde * 0.9;
                    picturePagto.Image = Properties.Resources.dinheiro;
                }

                lblTotal.Text = total.ToString("c");
                txtPreco.Enabled = false;
                txtQtde.Enabled = false;
                cboPagto.Enabled = false;
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
            txtPreco.Clear();
            txtPreco.Enabled = true;
            txtQtde.Clear();
            txtQtde.Enabled = true;
            cboPagto.SelectedIndex = 0;
            cboPagto.Enabled = true;
            lblTotal.Text = "";
            picturePagto.Visible = false;
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
