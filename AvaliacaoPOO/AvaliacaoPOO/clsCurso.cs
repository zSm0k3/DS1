using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoPOO
{
    internal class clsCurso
    {

        private string nomeCurso;

        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }

        private string sigla;

        public string Sigla
        {
            get { return sigla; }

            set
            {
                if (value.All(char.IsLetter) && value.Length > 2)
                {
                    sigla = value;
                }
                else
                {
                    MessageBox.Show("Digite no mínimo 3 letras para a sigla.");
                }            }
        }

        private string periodo;

        public string Periodo
        {
            get { return periodo; }

            set
            {
                if (value.All(char.IsLetter))
                {
                    periodo = value.ToUpper();
                }
                else
                {
                    MessageBox.Show("Digite apenas letras para período.");
                }
            }
        }

        private string nivel;

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public void consultar()
        {
            MessageBox
        }



    }
}
