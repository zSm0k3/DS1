namespace Exemplo_POO
{
    public partial class Form1 : Form
    {
        clsUsuario objUsuario = new clsUsuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            objUsuario.Nome = txtNome.Text;

            objUsuario.Email = txtEmail.Text;

            objUsuario.Login = txtLogin.Text;

            objUsuario.Senha = txtSenha.Text;
        }
    }
}
