namespace Tagarelo
{
    internal class Program
    {
        const string COMANDO_SAIR = "SAIR";
        const string COMANDO_REINICIAR = "REINICIAR";

        static void Main(string[] args)
        {
            ITagarela tagarela;
            var sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine($"Escolha o humor do seu Tagarelo:");
                Console.WriteLine($"*1 - Padrão");
                Console.WriteLine($" 2 - O aforista do caos");
                Console.WriteLine($" 3 - Seu Lunga");
                Console.WriteLine();

                var opcaoValida = int.TryParse(Console.ReadLine(), out int humor);

                switch (humor)
                {
                    case 2:
                        tagarela = new TagarelaAforismo();
                        Console.WriteLine("Você escolheu 2 - O aforista do caos.");
                        break;
                    case 3:
                        tagarela = new TagarelaSeuLunga();
                        Console.WriteLine("Você escolheu 3 - Seu Lunga.");
                        break;
                    default:
                        tagarela = new Tagarelador();
                        Console.WriteLine($"Opção padrão selecionada ({humor}): 1 - Padrão.");
                        break;
                }

                Console.WriteLine($"Digite uma mensagem para o programa Tagarelo. Para finalizar digite '{COMANDO_SAIR}'");

                while (opcaoValida)
                {
                    Console.WriteLine();

                    var mensagem = Console.ReadLine();

                    if (COMANDO_SAIR.ToUpper().Trim() == mensagem?.ToUpper().Trim())
                    {
                        sair = true;
                        break;
                    }
                    else if (COMANDO_REINICIAR.ToUpper().Trim() == mensagem?.ToUpper().Trim())
                        break;
                    else
                        tagarela.Tagarelar();
                }
            }
            Console.WriteLine();
        }
    }
}
