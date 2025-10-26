using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._3_SortedSet

{
    class SortedSet
    {
        static void Main(string[] args)
        {
            // Conjunto de alunos:
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo()) // Criaremos o parâmetro IComparer.
        {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian",
            "Priscila Stuani",
            "PRISCILA STUANI"
        };
            alunos.Add("Rafael Rollo");
            alunos.Add("RAFAEL ROLLO");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Códigos para operações matemáticas:
            ISet<string> outroConjunto = new HashSet<string>();


            // Este conjunto é subconjunto do outro? Para saber isso é necessária a implementação do código IsSubetOf:
            // Inicia com a instância ALUNOS, após selecionamos o código(que irá retornar um booleano dizendo se é ou não é).
            alunos.IsSubsetOf(outroConjunto);


            // Este conjunto é superconjunto do outro? Para saber isso é necessária a implementação do código IsSuperSetOf:
            alunos.IsSupersetOf(outroConjunto);


            // Os conjuntos contêm os mesmos elementos? Para saber isso é necessária a implementação do código SetEquals:
            alunos.SetEquals(outroConjunto);

            // Subtrai os elementos da outra coleção que também estão na coleção que também estão neste conjunto. Para saber isso é necessária a implementação do código ExceptWith:
            alunos.ExceptWith(outroConjunto);

            // Intersecção dos conjuntos. Para saber isso é necessária a implementação do código InterserctWith:
            alunos.IntersectWith(outroConjunto);

            // Elementos que estão em um ou outro conjunto, eliminando toda a intersecção. Para saber isso é necessária a implementação do código SymmetricExceptWith:
            alunos.SymmetricExceptWith(outroConjunto);

            // A união dos elementos dos dois conjuntos. Para saber isso é necessária a implementação do código UnionWith:
            alunos.UnionWith(outroConjunto);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        // O método Compare irá comparar as strings e retornar um resultado se ambas são iguais:
        // Queremos igualar ambas strings o maiúsculo e minúsculo.
        // Primeira maneira de ser feito:
        public int Compare (string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }

        // Segunda maneira de ser feito:

        //public int Compare(string aluno, string alunos)
        //{
        //    return string.Compare(aluno.ToUpper(), alunos.ToLower(), true);
        //}
    }
}
