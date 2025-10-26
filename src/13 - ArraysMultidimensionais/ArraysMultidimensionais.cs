namespace A2._1___ArraysMultidimensionais
{
    class ArraysMultidimensionais
    {
        static void Main(string[] args)
        {
            // Em string[,], teremos que colocar a vírgula para representar o fato de que temos duas dimensões:
            string[,] resultados = new string[4, 3]; // Aqui iremos colocar as 3 linhas(posições) e em seguida as 3 copas do mundo.
            //{
            //    {"Alemanha", "Espanha", "Itália"},
            //    {"Argentina", "Holanda", "França"},
            //    {"Holanda", "Alemanha", "Alemanha"},
            //};

            // Agora faremos o array utilizando index:

            resultados[0, 0] = "Alemanha"; // O 0 será o primeiro; // O 0 do lado direito será representado pelo ano da capo, no caso a de 2014.
            resultados[1, 0] = "Argentina";// O 1 será o segundo;
            resultados[2, 0] = "Holanda";  // O 2 será o terceiro.
            resultados[3, 0] = "Brasil";  // O 3 será o quarto.

            resultados[0, 1] = "Espanha";  // O 0 será o primeiro; // O 0 do lado direito será representado pelo ano da capo, no caso a de 2010.
            resultados[1, 1] = "Holanda";  // O 1 será o segundo;
            resultados[2, 1] = "Alemanha"; // O 2 será o terceiro.
            resultados[3, 1] = "Uruguai";  // O 3 será o quarto.

            resultados[0, 2] = "Itália";   // O 0 será o primeiro; // O 0 do lado direito será representado pelo ano da capo, no caso a de 2006.
            resultados[1, 2] = "França";   // O 1 será o segundo;
            resultados[2, 2] = "Alemanha"; // O 2 será o terceiro.
            resultados[3, 2] = "Portugal";  // O 3 será o quarto.

            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++) // Aqui colocaremos o índice (1).
            {
                int ano = 2014 - copa * 4; // Cálculo do ano
                Console.Write(ano.ToString().PadRight(12));
            // Realizei a troca de Console.WriteLine para Console.Write, pois deve-se imprimir na mesma linha
            }
            Console.WriteLine();

            // A posicao é igual a 0 pois o índice se inicia nele:
            // Queremos que o código indique as posições automaticamente sem a necessidade de ficar alterando a posição manualmente.
            // Para isso é necessário calcular qual é o tamanho da matriz naquela dimensão:
            // Para fazer isso iremos acessar o nosso array "resultados" e chamaremos um método, o "GetUpperBound()", e então colocaremos nele o índice da dimensão que estou procurando:
            for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
            {
            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
            {
                Console.Write(resultados[posicao, copa].PadRight(12));
            }
            Console.WriteLine();

            }


        }
    }
}