namespace A5._2___Foreach
{
    public class Foreach
    {
        static void Main(string[] args)
        {
            var meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var item in meses)
            {
                Console.WriteLine(item.ToUpper());
            }
            for (int i = 0; i < meses.Length; i++)
            {
                var mes = meses[i];
                //....
            }
        }
    }
}