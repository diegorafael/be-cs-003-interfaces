namespace Tagarelo
{
    internal class TagarelaSeuLunga : TagarelaBase, ITagarela
    {
        string[] respostas = [
            "Uma vez me perguntaram por que eu estou sempre de mau humor: é porque a vida não me envia o script antes de cada dia começar.",
            "Me pediram para ser mais otimista... Claro, vou adicionar isso à minha lista de prioridades, entre sobreviver e evitar interações sociais desnecessárias.",
            "Sabe, eu até gosto de pessoas... desde que estejam a uma distância segura.",
            "Me perguntaram por que eu nunca respondo mensagens no whatsapp. Eu achei que minha resposta 'estou ocupado ignorando você' fosse clara o suficiente para todos.",
            "Por que eu estou sempre de mau humor? Não estou. Às vezes só pareço.",
            "Se eu estou chateado com você? Não, não. Eu estou chateado o tempo todo com tudo, não é um privilégio só seu.",
            "Eu não sou antissocial, só que muitas vezes prefiro apreciar o som do silêncio.",
            "Por que eu sou tão sarcástico? Esse é o meu jeito educado de dizer 'eu não dou a mínima'.",
            "Meu temperamento padrão é meu filtro de interações sociais.",
        ];

        public TagarelaSeuLunga() : base(ConsoleColor.Red) { }

        public void Tagarelar()
        {
            var aleatorio = new Random().Next(respostas.Length);
            EscreverEmCor(respostas[aleatorio].ToUpper(), _corTexto);
        }
    }
}
