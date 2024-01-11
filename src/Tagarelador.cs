namespace Tagarelo
{
    internal class Tagarelador
    {
        const ConsoleColor TEXT_COLOR = ConsoleColor.Magenta;

        string[] respostas = [
            "Blá, blá, blá.",
            "Lero, lero, lero",
            "Ti, ti, ti",
            "Ohmn...",
            "Ahn?!",
        ];

        public void Tagarelar()
        {
            var aleatorio = new Random().Next(respostas.Length);
            FormatText(respostas[aleatorio]);
        }

        private static void FormatText(string conteudo)
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = TEXT_COLOR;
            Console.WriteLine(conteudo);
            Console.ForegroundColor = anterior;
        }
    }
}
