namespace Tagarelo
{
    internal class Program
    {
        const string COMANDO_SAIR = "SAIR";

        static void Main(string[] args)
        {
            var tagarelador = new Tagarelador();

            Console.Clear();
            TextoEmCor("------- INICIO -------", ConsoleColor.DarkGray);
            Console.WriteLine($"Digite uma mensagem para o programa Tagarelo. Para finalizar digite '{COMANDO_SAIR}'");

            while (true)
            {
                Console.WriteLine();

                var mensagem = Console.ReadLine();

                if (COMANDO_SAIR.ToUpper().Trim() != mensagem.ToUpper().Trim())
                {
                    TextoEmCor(tagarelador.Tagarelar(), ConsoleColor.Magenta);
                }
                else 
                    break;
            }

            Console.WriteLine();
            TextoEmCor("------------ FIM ------------", ConsoleColor.DarkGray);
        }

        private static void TextoEmCor(string conteudo, ConsoleColor cor)
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = cor;
            Console.WriteLine(conteudo);
            Console.ForegroundColor = anterior;
        }
    }
}
