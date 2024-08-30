using System.Drawing;

namespace Medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMedida.Clear();
            txtMedida.Enabled = true;
            txtMedidaCnvtda.Clear();
            txtMedidaCnvtda.Enabled = true;
            cboDe.SelectedIndex = -1;
            cboPara.SelectedIndex = -1;
            /*cboDe.Enabled = true;*/
            /*cboPara.Enabled = true;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDe.SelectedIndex = -1;
            cboPara.SelectedIndex = -1;
        }

        private void cboPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            float medida, medidaCnvtda = 0;

            if (cboPara.SelectedIndex != -1)
            {
                try
                {
                    medida = float.Parse(txtMedida.Text);

                    // cm
                    if (cboDe.SelectedIndex == 0)
                    {
                        switch (cboPara.SelectedIndex)
                        {
                            // m
                            case 1: medidaCnvtda = medida * 100 ; break;

                            // Km
                            case 2: medidaCnvtda = medida * 100000 ; break;

                            default: medidaCnvtda = medida; break;
                        }
                    }


                    // m
                    else if (cboDe.SelectedIndex == 1)
                    {
                        switch (cboPara.SelectedIndex)
                        {
                            // cm
                            case 1: medidaCnvtda = medida / 100; break;

                            // Km
                            case 2: medidaCnvtda = medida * 1000; break;

                            default: medidaCnvtda = medida; break;
                        }
                    }

                    // Km
                    else if (cboDe.SelectedIndex == 2)
                    {
                        switch (cboPara.SelectedIndex)
                        {
                            // m
                            case 1: medidaCnvtda = medida / 100; break;

                            // cm
                            case 2: medidaCnvtda = medida / 100000; break;

                            default: medidaCnvtda = medida; break;
                        }
                    }

                    txtMedidaCnvtda.Text = $"{medidaCnvtda:N2}";
                    txtMedidaCnvtda.BackColor = Color.Yellow;
                }
                catch (Exception)
                {
                    MessageBox.Show("Preencha os campos corretamente?", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMedida.Focus();
                }
            }
        }
    }
}