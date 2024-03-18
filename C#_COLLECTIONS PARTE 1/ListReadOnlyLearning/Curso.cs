using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReadOnlyLearning
{
    // Declaração de propriedades, por meio de uma classe com arquivo separado:
    class Curso
    {
        // Primeira propriedade que foi protegida de códigos externos, utilizando o ReadOnlyCollection:
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        // Construtor para iniciar a lista de aulas:
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();

        }

        // Segunda propriedade da classe curso:
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        // Terceira propriedade da classe curso:
        private string instrutor;
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        // Propriedade que calcula o tempo total do curso inteiro:
        public int TempoTotal
        {
            // Primeira forma de realizar o cálculo:

            get
            {
                //    int total = 0;
                //    foreach (var aula in aulas)
                //    {
                //        total += aula.Tempo;
                //    }
                //    return total;

                // LINQ = Language Integrated Query.
                // Consulta integrada á linguagem.
                // Segunda forma de realizar o cálculo:
                return aulas.Sum(aula => aula.Tempo);

            }
        }

        // Método criado para adcionar um curso após a proteção do ReadOnlyCollection:
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }
        // Chamaremos o override pois ele é uma operação de sobrescrever um método que já existe em uma classe (no caso a classe obj):
        public override string ToString()
        {
            return $"Curso:{nome} , Tempo:{TempoTotal} , Aulas: {string.Join(",", aulas)}.";
        }
    }
}
