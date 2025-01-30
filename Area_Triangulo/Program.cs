using System.Diagnostics;

namespace Area_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Cálcular a Área do Triângulo");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.WriteLine("Escreva qual a base do triângulo: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva qual a altura do triângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            area(bas, altura);
        }

        static void area(int b, int al)
        {
            double a = (b * al) / 2;
            Console.WriteLine($"Um triângulo com as dimensões de base = {b} e altura= {al}, tem uma área de {a:F2}m²");
        }
    }
}
