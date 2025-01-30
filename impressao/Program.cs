namespace impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Se eu fosse você 2 é o melhor filme do mundo");
            Console.WriteLine();

        }

        static void escreva(string texto)
        {
            char caracter = '=';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            string TextoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho);
            Console.WriteLine(linha);
            Console.WriteLine(TextoCentralizado);
            Console.WriteLine(linha);
        }
    }
}
