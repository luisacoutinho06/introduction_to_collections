using System.Linq;

namespace A4._2___OperadoresDeConjuntos
{
    public class OperadoresDeConjuntos
    {
        static void Main(string[] args)
        {
            string[] seq1 = {"janeiro", "fevereiro", "março"};
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            // Neste momento iremos concatenar essas duas listas
            Console.WriteLine("Concatenando duas sequências:");

            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Iremos realizar a união das duas listas:
            Console.WriteLine("União de duas sequências:");

            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Iremos realizar a união de ambas sequências com o comparador:
            Console.WriteLine("União de duas sequências com comparador:");

            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Iremos realizar a interseção de duas sequências:
            Console.WriteLine("Interseção de duas sequências:");

            var consulta4 = seq1.Intersect(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Ao inserirmos a primeira sequência compararemos com a segunda e filtraremos os elementos presentes na 1ª sequência não estando presente na 2ª:
            Console.WriteLine("Exceto: elementos de seq1 que não estão na seq2:");

            var consulta5 = seq1.Except(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}