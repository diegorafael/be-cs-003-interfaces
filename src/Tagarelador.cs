namespace Tagarelo
{
    internal class Tagarelador : TagarelaBase, ITagarela
    {
        string[] respostas = [
            "Blá, blá, blá.",
            "Lero, lero, lero",
            "Ti, ti, ti",
            "Ohmn...",
            "Ahn?!",
        ];

        public Tagarelador() : base(ConsoleColor.Magenta) { }

        public void Tagarelar()
        {
            var aleatorio = new Random().Next(respostas.Length);
            EscreverEmCor(respostas[aleatorio], _corTexto);
        }
    }
}
