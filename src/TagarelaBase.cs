namespace Tagarelo
{
    internal abstract class TagarelaBase
    {
        protected readonly ConsoleColor _corTexto;

        public TagarelaBase(ConsoleColor corTexto)
        {
            _corTexto = corTexto;
        }

        protected virtual void EscreverEmCor(string conteudo, ConsoleColor cor)
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = cor;
            Console.WriteLine(conteudo);
            Console.ForegroundColor = anterior;
        }
    }
}
