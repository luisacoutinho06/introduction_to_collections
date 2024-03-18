namespace _9___QueueLearning
{
    // Realizando uma fila de pedágios
    class QueueLearning
    {
        // Esta variável estática que será uma coleção que representará a fila (Queue):
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            // Entrada de carros na fila do pedágio:

            // Entrou: van
            Enfileirar("van");

            // Entrou: kombi
            Enfileirar("kombi");

            // Entrou: guincho
            Enfileirar("guincho");

            // Entrou:pickup
            Enfileirar("pickup");



            // Liberação do carro:

            //Saiu da fila a van:
            Desenfileirar();

            //Saiu da fila a kombi:
            Desenfileirar();

            //Saiu da fila o guincho:
            Desenfileirar();

            //Saiu da fila a pickup:
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
            // Método para ver quem será o próximo a carro a ser liberado:
            if (pedagio.Peek() == "guincho")
            {
                Console.WriteLine("Guincho está realizando o pagamento!");
            }

           // Método para a retirada do vaículo da fila (liberação do carro):
           string veiculo = pedagio.Dequeue();
           Console.WriteLine($"Saiu da fila: {veiculo}");
           ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");

            // Para realmente adicionar uma fila teremos que pegar a variável pedágio e chamar um método para adicionar o elemento, dessa maneira que é feito em uma coleção:
            pedagio.Enqueue(veiculo);

            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}