namespace _7___LinkedListLearning
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            // Instanciando uma nova lista ligada: dias da semana ->
            LinkedList<string> dias = new LinkedList<string>();

            // Adicionando algum dia qualquer: "quarta" ->
            var d4 = dias.AddFirst("quarta");

            // Quarta é o primeiro elemento da lista ligada
            // Cada elemento é um nó: LinkedListNode<T> 
            // Para acessar o valor do nó é necessário fazer da seguinte forma:
            //Console.WriteLine("d4.Value: " + d4.Value);

            // Como fazemos para adicionar mais intens na lista ligada? O LinkedList não possui Add!
            // Podemos adicionar de 4 formas:
            // 1. Para adicionar o primeiro nó é o AddFirst.
            // 2. Para adicionar o último nó é o AddLast.
            // 3. Para adicionar antes de um nó conhecido é o AddBefore.
            // 3. Para adicionar depois de um nó conhecido é o AddAfter.

            // Adcionando a segunda, antes de quarta:
            var d2 = dias.AddBefore(d4, "segunda");

            // Agora o d2 e d4 estão ligados!
            // - d2.Next é igual a d4
            // - d4.Previous é igual a d2

            // Continuando com a lista ligada, vamos adicionar a terça depois da segunda:
            var d3 = dias.AddAfter(d2, "terça");

            // Adicionando a sexta depois da quarta:
            var d6 = dias.AddAfter(d4, "sexta");

            // Adicionando o sábado depois da sexta:
            var d7 = dias.AddAfter(d6, "sábado");

            // Adicionando quinta antes da sexta:
            var d5 = dias.AddBefore(d6, "quinta");

            // Adicionando o domingo antes da segunda:
            var d1 = dias.AddBefore(d2, "domingo");


            // O LinkedList NÃO DÁ suporte ao acesso de índice: dias[0], por isso podemos fazer um laço foreach, mas não um for.
            var quarta = dias.Find("quarta");

            // Para removermos um elemento, podemos tanto remover pelo valor quanto pela referência do LinkedListNode, desta forma:
            //dias.Remove("quarta") ou dias.Remove(d4);
            dias.Remove("quarta");


            // Imprimindo a lista:
            foreach ( var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}