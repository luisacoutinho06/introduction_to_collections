using System.Collections.Immutable;

namespace ListReadOnlyLearning
{
    class ListReadOnlyLearning
    {
        static void Main(string[] args)
        {
            // Variável "Curso" chamada "csharpColecoes", onde chamaremos a propriedade pública "Aulas". Adicionaremos uma nova aula a esta lista com o método Add(), passando como parâmetro uma nova instância da classe Aula. Desta forma?
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            // Adição de duas aulas novas:
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));
            Imprimir(csharpColecoes.Aulas);

            // Ordenar a lista de aulas (colocá-las em lista alfabética):
            // Porém o IList não oferece suporte para o método Sort. Então deve-se realizar de outra forma.
            //csharpColecoes.Aulas.Sort();

            // Iremos copiar uma lista para outra lista, ordenando em ordem alfabética:
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            // Ordenar a cópia:
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //Totalizar o tempo total do curso:
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);
        }
        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

    }
}