namespace Tagarelo
{
    internal class TagarelaAforismo : TagarelaBase, ITagarela
    {
        string[] respostas = [
            "Tropecei na vida e caí na ironia. Pelo menos, ganhei experiência de queda.",
            "A vida é um palco, mas algumas vezes o figurino é mais cômico do que trágico.",
            "Se a vida te der limões, faça uma piada ácida e chame de limonada.",
            "A ironia da vida: você passa metade dela dormindo e a outra metade querendo uma soneca.",
            "O café é como o humor: preto, forte e necessário para sobreviver às segundas-feiras.",
            "Amor é cego, mas o senso de humor é o GPS que nos ajuda a navegar na estrada do relacionamento.",
            "O problema da vida é que ela não vem com um controle remoto. Às vezes, um mute seria útil.",
            "A dieta é como uma piada sem graça: você tenta, mas é difícil manter por muito tempo.",
            "A diferença entre um problema e uma piada está no timing. E o timing é tudo na comédia... e na vida.",
            "A idade é só um número, mas rir das rugas é uma maneira divertida de contar a história."
        ];

        public TagarelaAforismo() : base(ConsoleColor.Blue) { }

        public void Tagarelar()
        {
            var aleatorio = new Random().Next(respostas.Length);
            EscreverEmCor(respostas[aleatorio], _corTexto);
        }
    }
}
