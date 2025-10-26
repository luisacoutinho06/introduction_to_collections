using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___SetInModelLearning
{
    class Aluno
    {
		private string nome;
		public string Nome
        {
			get { return nome; }
			set { nome = value; }
		}

		private int numeroMatricula;
        public int NumeroMatricula
		{
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}

        public Aluno(string nome, int numeroMatricula)
        {
            this.numeroMatricula = numeroMatricula;
            this.nome = nome;

        }
        public override string ToString()
        {
            return $"[Nome: {Nome}, Matrícula: {numeroMatricula}.]";
        }

        // Sempre que implementar o equals, uma boa prática é implementar o GetHashCode
        public override bool Equals(object? obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null) 
            {
                return false; 
            }
            return this.nome.Equals(outro.nome);
        }

        // Trata-se de um código de dispersão, ou espalhamento. A imagem abaixo representa o nosso conjunto de alunos, que são convertidos internamente no HashSet para códigos.
        // Estes cairão em uma tabela de dispersão, também conhecida por HashTable, responsável por informar as "caixinhas" em que estes conjuntos de alunos cairão.
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
