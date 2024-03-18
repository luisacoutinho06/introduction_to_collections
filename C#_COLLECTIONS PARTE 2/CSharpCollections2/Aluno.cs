using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._1_SortedList
{
    public class Aluno
    {
        // Nome do aluno:
        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        // Número de matrícula do aluno:
        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        // Temos o construtor que recebe o nome do aluno e sua matrícula, para que preencha os dados do aluno:
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        // Método virtual do tipo object que sobrescreve o ToString para que retorne uma representação da string.
        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula;
        }
    }
}
