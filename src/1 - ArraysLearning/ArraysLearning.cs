using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CSharpCollections
{
    internal class ArraysLearning
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução ás coleções";
            string aulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando com conjuntos";

            // Primeira forma de introduzir uma coleção (array) de elementos:

            //string[] aulas0 = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};


            // Segunda forma de introduzir uma coleção (array) de elementos:

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //Console.WriteLine(aulas0);

            Console.WriteLine(aulas);

            Imprimir(aulas);



            // Imprimindo o primeiro elemento do índice do array:
            Console.WriteLine(aulas[0]);

            // Imprimindo o último elemento do índice do array:
            Console.WriteLine(aulas[aulas.Length - 1]);



            // Atribuindo um valor a posição desejada:
            aulas[0] = "Trabalhando com arrays";
            // Então o valor atribuído será impresso:
            Imprimir(aulas);



            // Desta forma iremos procurar um elemento que está contido dentro do array:
            Console.WriteLine("A aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando) + ".");

            // Digamos que este texto seja repetido algumas vezes dentro do array, caso queira ver qual a última ocorrência, devemos fazer da seguinte forma:
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            // Para reverter a array, inverter os elementos, fazemos da seguinte forma:
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Reverteu novamente porém para a ordem que estava anteriormente.
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Para redimensionar o array (transoforma-lo de um tamanho 3 para 2) utilizamos o seguinte código: (Este REF, significa referênciar)
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            // Para retornar para o tamanho normal é só introduzir o seguinte código:
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            // Este "aulas.Lenght - 1" garante que estou sempre acessando a última posição do array.
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            // Caso seja necessário ordenar este array(coleção) em ordem alfabética é só utilizar o método estático "Sort" (é algo que não pode ser revertido, não é idempotente.):
            Array.Sort(aulas);
            Imprimir(aulas);

            // Suponhamos que eu queira copiar este array para outro array:
            string[] copia = new string[2];
            Array.Copy(aulas, 1,  copia, 0, 2);
            Imprimir(copia);

            // Caso seja necessário fazer uma cópia de todos os elementos, utilizamos o seguinte método estático:
            string[] clone =  aulas.Clone() as string[];
            Imprimir(clone);

            // Para realizar a limpeza de alguns elementos do array clone, nesse caso os dois últimos, faremos utilizando o método estático clear:
            Array.Clear(clone, 1, 2);
            Imprimir(clone);

        }

        // Método
        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}


            // O laço FOR irá varrer a posição de um ÍNDICE até a posição FINAL.
            // Então ele vai pegar esse i (índice que ele chama de i) até o comprimento final do parâmetro.
            for (int i = 0; i < aulas.Length; i++)
            {
                // Agora será acessado o elemento AULAS que tem o índice i que está sendo varrido no momento.
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
