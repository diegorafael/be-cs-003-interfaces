namespace Tagarelo
{
    internal class Program
    {
        const string COMANDO_SAIR = "SAIR";

        static void Main(string[] args)
        {
            var tagarelador = new Tagarelador();

            Console.Clear();
            Console.WriteLine("------- INICIO -------");
            Console.WriteLine($"Digite uma mensagem para o programa Tagarelo. Para finalizar digite '{COMANDO_SAIR}'");

            while (true)
            {
                Console.WriteLine();

                var mensagem = Console.ReadLine();

                if (COMANDO_SAIR.ToUpper().Trim() != mensagem.ToUpper().Trim())
                    tagarelador.Tagarelar();
                else 
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("------------ FIM ------------");
        }
    }
}
