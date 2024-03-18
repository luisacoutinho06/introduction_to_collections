using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._1_SortedList
{
    class SortedList
    {
        static void Main(string[] args)
        {
            // Vamos criar um dicionário de alunos:
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));



            // Imprimindo no console os alunos:
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Linha vazia:
            Console.WriteLine();


            // Ao executar o programa a ordem que aparece é a mesma que foi colocada pelo programador. Será que essa ordem é realmente mantida? vamos testar:
            alunos.Remove("AL");

            // Acrescentando novo aluno no lugar:
            alunos.Add("MO", new Aluno("Marcelo", 12345));


            // Imprimindo no console os alunos:
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }


            // Apresentando nova coleção chamada de SortedList (um dicionário ordenado, ou seja é uma lista onde as chaves se ordenam automaticamente, você inserindo ou não um valor):
            // Para visualizar a implementação do SortedList é só selecioná-lo e apertar as teclas ALT + F12:
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));


            // Linha vazia:
            Console.WriteLine();

            // Imprimindo no console os alunos:
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
