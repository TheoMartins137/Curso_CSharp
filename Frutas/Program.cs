namespace Frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Maçã", "Pera", "Melancia", "Uva", "Morango", "Abacate", "Banana", "Jabuticaba", "Acerola", "Kiwi" };
            double[] preco = { 10.80,   5.89,    15.99,      3.25,    4.50,     9.90,      3.10,      6.87,       12.89,     8.45 };

            string frutas2 = frutas.Max();
            string frutas3 = frutas.Min();

            double preco2 = preco.Max();
            double preco3 = preco.Min();

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("A fruta {0} custa R${1}", frutas[i], preco[i]);
            }
            Console.WriteLine();
            Console.WriteLine("A primeira fruta em ordem alfabética é a: {0}, no valor de R${1}", frutas3, preco[5]);
            Console.WriteLine("A ultima fruta em ordem alfabética é a: {0}, no valor de R${1}", frutas2, preco[3]);
            Console.WriteLine("A fruta mais barata é a: {0}, no valor de R${1}", frutas[6], preco3 );
            Console.WriteLine("A fruta mais cara é a: {0}, no valor de R${1}", frutas[2], preco2 );
        }
    }
}
