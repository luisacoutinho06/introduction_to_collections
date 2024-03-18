namespace _8___StackLearning
{
    class StackLearning
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
        }
    }
    internal class Navegador
    {
        // É necessário alterarmos o método NavegarPara() para salvar a página atual e ser substituída. Para isto, criaremos uma coleção denominada Pilha, ou Stack, em inglês.
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();

        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        // Utilizamos o método Pop que é responsável por pegar o próximo elemento de uma pilha. Ele retornar uma string, portanto precisaremos armazená-la em algum lugar:
        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
            historicoProximo.Push(atual);
            atual = historicoAnterior.Pop();
            Console.WriteLine("Página atual: " + atual);
            }
        }

        // Utilizamos o método Push para receber nossa página atual (salvá-la):
        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
            historicoAnterior.Push(atual);
            atual = historicoProximo.Pop();
            Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}