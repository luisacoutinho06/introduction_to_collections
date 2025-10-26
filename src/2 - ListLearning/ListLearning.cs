namespace ListLearning
{
    class ListLearning
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução ás coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            // Primeira forma de realizar a declaração de uma coleção lista é necessário inserir o "List" e no sinal de <> inserir seu tipo, se é int, string etc, e logo após, setar o nome da lista, dessa forma:
            //    List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};


            // A segunda forma de realizar a declaração de uma coleção de lista(também chamada de array dinâmico), é utilizando o seguinte código:
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            // Formas de se imprimir os elementos:
            Imprimir(aulas);

            // Desta forma é trago pelo índice específico:
            Console.WriteLine("A primeira aula é " + "\"" + aulas[0]+ "\"" + ".");

            // Desta forma é trago o último elemento da lista:
            Console.WriteLine("A última aula é " + "\"" + aulas[aulas.Count - 1] + "\"" + ".");
            Console.WriteLine("A última aula é " + "\"" + aulas.Last() + "\"" + ".");

            // Desta forma é trago o primeiro elemento da lista:
            Console.WriteLine("A primeira aula é " + "\"" + aulas.First()+ "\"" + ".");


            // Códio para atribuir um novo valor a um determinado elemento:
            aulas[0] = "Trabalhando com listas";
            Imprimir(aulas);

            // Código para procurar uma palavra dentro da lista de elementos:
            Console.WriteLine("A primeira aula 'Trabalhando' é: " 
                + aulas.First(aula => aula.Contains("Trabalhando")));

            // Código para procurar uma palavra dentro da lista de elementos:
            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            // Código para procurar uma palavra dentro da lista de elementos e retornar caso esse valor não exista:
            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            // Para inverter as ordens dos elementos é necessário este código que é feito diretamente no obj aulas:
            aulas.Reverse();
            Imprimir(aulas);

            // Para reverter as ordens dos elementos para o padrão anterior é necessário este código que é feito diretamente no obj aulas:
            aulas.Reverse();
            Imprimir(aulas);

            // Para remover um elemento de uma posição específica, é necessário chamar este método:
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            // Para adcionar um elemento na coleção lista, é necessário chamar este método:
            aulas.Add("Conclusão");
            Imprimir(aulas);

            // Para ordenar esta lista em ordem alfabética, é necessário chamar este método:
            aulas.Sort();
            Imprimir(aulas);

            // Para realizar uma cópia desta lista, é necessário declarar uma lista e chamar o método para obter uma faixa de valores:
            List<string> copia = aulas.GetRange(aulas.Count -2, 2);
            Imprimir(copia);

            // Para realizar um clone (não existe um método de clonagem, igual ao array), é necessário declarar o nome da lista, basicamente iremos obter uma nova lista apartir da lista de aulas, instanciando o clone. 
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            // Para remover uma faixa elementos da lista clone, é necessário colocar o método RemoveRange e então passamos o índice da primeira posição que queremos remover como primeiro parâmetro e, como segundo, a quantidade que queremos remover, que é 2:
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

        }

        private static void Imprimir(List<string> aulas)
        {
            // Primeira maneira para se imprimir e visualizar os elementos:

            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aulas);
            //}


            // Segunda maneira para se imprimir e visualizar os elementos:

            //for (int i = 0; i < aulas.Count ; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}


            // Terceira maneira para se imprimir e visualizar os elementos:
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
        }
    }
}