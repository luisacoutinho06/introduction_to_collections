namespace A5._1___Convariancia
{
    public class Convariancia
    {
        static void Main(string[] args)
        {
            // Iremos fazer uma conversão explicita de uma string para um tipo object:
            // Todas as classes herdam do object.
            Console.WriteLine("String para object:");

            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);

            Console.WriteLine();

            // Conversão do tipo lista de string para o tipo lista de object?
            Console.WriteLine("List<string> para List<object>:");

            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            // IList<object> listaObj = listaMeses;
            Console.WriteLine();

            // Iremos converter um array de string para um array de object:
            Console.WriteLine("strin[] para object[]?");

            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses; // CONVARIÂNCIA!
            Console.WriteLine(arrayObj);

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //arrayObj[0] = 12345;
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            // Caso eu queira trocar o primeiro arrayObj para um número invés desta string:
            //arrayObj[0] = "PRIMEIRO MÊS";
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            // Transformando uma lista de strings em um IEnumebrale de object:
            Console.WriteLine("List<string> para IEnumerable<object>:");

            IEnumerable<object> enumObj = listaMeses; //COVARIÂNCIA!
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}