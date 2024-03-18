namespace _6___SetInModelLearning
{
    class SetInModelLearning
    {
        static void Main(string[] args)
        {
            // Declaração do curso:
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            //... e adcionando as 3 aulas a esse curso
            // Trabalhando com listas - 21 minutos;
            // Criando uma aula - 20 minutos;
            // Modelando com coleções - 24 minutos

            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 24));

            // Instanciando os 3 alunos com suas matrículas:
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rfael Nercessian", 17645);

            // Matriculando os alunos no curso, criando um método:
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            // Imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados:");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno.ToString());
            }

            // Imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");

            // Criar um método EstaMatriculado:
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // Instanciar uma aluna (Vanessa Tonini):
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            // Não é reconhecido que essa segunda instância é igual a primeira instância 
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

            // Verificação se a1 == a Tonini?
            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);

            // Verificação utilizando o método equals:
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

            // Limpando o console:
            Console.Clear();

            // Já possuímos um método para saber se o aluno está matriculado.
            // Agora é necessário buscar o aluno pelo número de matrícula.
            // Deve-se responder esta pergunta "Quem é o aluno com a matrícula 5617?":
            Console.WriteLine("Quem é o aluno com a matrícula 5617?");

            // Implementando um novo método para buscar o aluno pela matrícula, "Curso.BuscaMatriculado":
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            // Imprimindo o aluno 5617 que foi encontrado:
            Console.WriteLine("aluno5617: " + aluno5617);

            // Implementando um método de busca mais eficiente.
            // Implementando uma nova coleção: dicionário. Um dicionário permite associar uma chave (no caso, matrícula) a um valor (o aluno).


            // O que acontece quando se puxa um aluno inexistente? "Quem é o aluno 5618"?
            Console.WriteLine("Quem é o aluno 5618");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

            // E se tentarmos adicionar outro aluno com a mesma chave 5617? 
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(fabio); 
            // ------> Ocorre um erro, pois uma das características do dicionário é o fato de que a chave é única.

            // E se quisermos trocar o aluno que possui a chave específica?
            csharpColecoes.SubstituiAluno(fabio);

            // Pergunta: "Quem é o aluno 5617 agora?"
            Console.WriteLine("Quem é o aluno 5617 agora?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));



        }
    }
}