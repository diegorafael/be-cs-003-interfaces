namespace Tagarelo
{
    internal class Tagarelador
    {
        string[] respostas = [
            "Blá, blá, blá.",
            "Lero, lero, lero",
            "Ti, ti, ti",
            "Ohmn...",
            "Ahn?!",
        ];

        public string Tagarelar()
        {
            var aleatorio = new Random().Next(respostas.Length);
            return respostas[aleatorio];
        }
    }
}
