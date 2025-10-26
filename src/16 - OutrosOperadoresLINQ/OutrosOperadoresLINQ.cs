namespace A4._1___OutrosOperadoresLINQ
{
    // Alguns operadores de LINQ e suas funções específicas:
    public class OutrosOperadoresLINQ
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro     ",31),
                new Mes("Fevereiro   ",28),
                new Mes("Março       ",31),
                new Mes("Abril       ",30),
                new Mes("Maio        ",31),
                new Mes("Junho       ",30),
                new Mes("Julho       ",31),
                new Mes("Agosto      ",31),
                new Mes("Setembro    ",30),
                new Mes("Outubro     ",31),
                new Mes("Novembro    ",30),
                new Mes("Dezembro    ",31),
            };

            // Como filtrar os três primeiros elementos:
            var consulta = meses.Take(3);
            foreach (var mes in consulta)
            {
                Console.WriteLine(mes);
            }
            Console.WriteLine();

            // Filtraremos os meses após os três primeiros elementos:
            var consulta2 = meses.Skip(3);
            foreach (var mes in consulta2)
            {
                Console.WriteLine(mes);
            }
            Console.WriteLine();

            // Filtrar os meses três meses do trimestre(após os 6 meses):
            var consulta3 = meses.Skip(6).Take(3);
            foreach (var mes in consulta3)
            {
                Console.WriteLine(mes);
            }
            Console.WriteLine();

            // Filtrar os meses até que o mês inicie com a letra 's':
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var mes in consulta4)
            {
                Console.WriteLine(mes);
            }
            Console.WriteLine();

            //Filtar os meses que se iniciam com a letra S:
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var mes in consulta5)
            {
                Console.WriteLine(mes);
            }
            Console.WriteLine();
        }

        class Mes : IComparable
        {
            public Mes(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }
            public string Nome { get; private set; }
            public int Dias { get; private set; }

            public int CompareTo(object obj)
            {
                Mes outro = obj as Mes;

                return this.Nome.CompareTo(outro.Nome);
            }

            public override string ToString()
            {
                return $"{Nome} - {Dias}";
            }
        }
    }
}