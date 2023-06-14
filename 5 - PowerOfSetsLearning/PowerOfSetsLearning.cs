namespace _5___PowerOfSetsLearning
{
    class PowerOfSetsLearning
    {
        static void Main(string[] args)
        {
            // SETS = CONJUNTOS
            // O sets possui duas características principais: não permite duplicidade e os elementos não são mantidos em ordem específica.

            // Declarando o set dos alunos:
            ISet<string> alunos = new HashSet<string>(); //Uma interface genérica do .NET que exige que se passe o tipo do elemento deste conjunto (neste caso, string, pois armazenaremos os nomes dos alunos).

            // Adicionando: Vanessa, Ana, Rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            //Removendo um aluno e acrescentando outro para visualizar a ordem:
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Franscisco");



            // Testando a primeira característica do set: não permite duplicidade:
            alunos.Add("Fabio Gushiken");



            // Testando a segunda característica do set: não permite ordenação:
            //alunos.Sort();    --------> Erro

            // Realizando algo parecido mas utilizando uma cópia:
            List<string> alunosEmLista = new List<string>(alunos);

            // ordenando a lista:
            alunosEmLista.Sort();


            // Imprimindo
            Console.WriteLine(string.Join(", ", alunos));

            // Imprimindo a cópia:
            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}