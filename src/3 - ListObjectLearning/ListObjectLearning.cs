namespace ListObjectLearning
{
    class ListObjectLearning
    {
        static void Main(string[] args)
        {
            // Lista de strings(titulos) que armazenas as aulas:

            //string aulaIntro = "Introdução ás coleções";
            //string aulaModelando = "Modelando a classe aula";
            //string aulaSets = "Trabalhando com conjuntos";

            // Agora as strings serão trocadas por instâncias(um objeto cujo comportamento e estado são definidos pela classe) da classe aula:
            var aulaIntro = new Aula("Introdução ás coleções", 20); // Dessa forma a própria string será passada como parâmetro (no caso o titulo da aula) e seguido do parâmetro da aula (no caso 20m para a primeira aula).
            var aulaModelando = new Aula("Modelando a classe aula", 18); 
            var aulaSets = new Aula("Trabalhando com conjuntos", 16); 

            // Agora será criado a instância da listagem:
            List<Aula> aulas = new List<Aula>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            // Realizando a ordenação do titulo usando o IComparable:
            aulas.Sort();
            Imprimir(aulas);

            // Caso eu queira realizar uma ordenação diferente, por exemplo pelo tempo de duração invés do titulo, é necessário que eu faça da seguinte forma:
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);


        }

        // Geração de método para imprimir na tela:
        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    // Lista de objetos do tipo aula onde irá referênciar a duração da aula, uma lista que as armazene:
    class Aula : IComparable
    {
        // Dois campos, propriedades:
        private string titulo;
        private int tempo;

        // Construtor gerado(Um construtor serve para instanciar objetos da classe na qual esse construtor foi definido.):
        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        // Propriedades homônimas geradas a partir dos dois campos:
        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        // Método para comparar dois elementos  e fazer parte da classe aula (vai comparar uma aula com a outra):
        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        // Ao rodarmos a aplicação, aparece o namespace + a classe aula, sendo que queremos o titulo da aula. Para resolver isso temos que realizar um override(é necessário para estender ou modificar a implementação abstrata ou virtual de um método, propriedade, indexador ou evento herdado.), desta forma:
        public override string ToString()
        {
            return $"[Título: {titulo}, tempo: {tempo} minutos]";
        }
    }
}