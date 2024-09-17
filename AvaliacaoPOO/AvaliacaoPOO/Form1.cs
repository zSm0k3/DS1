namespace AvaliacaoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsCurso objCurso = new clsCurso();

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            objCurso.NomeCurso = $"{cboNomeCurso.SelectedItem}";
            objCurso.Sigla = txtSigla.Text;
            objCurso.Nivel = $"{cboNivel.SelectedItem}";
            objCurso.Periodo = txtPeriodo.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Curso:{objCurso.NomeCurso}" +
                $"\nSigla: {objCurso.Sigla}" +
                $"\nNível: {objCurso.Nivel}" +
                $"\nPeríodo:{objCurso.Periodo}");
        }
    }
}
