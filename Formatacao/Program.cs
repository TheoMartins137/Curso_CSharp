namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.5726;
            double num2 = 61782.1029;

            Console.WriteLine($"{num1:F2}");
            Console.WriteLine($"{num2:N2}");
            Console.WriteLine($"{num1:C2}");
            Console.WriteLine($"{num2:E2}");
            Console.WriteLine($"{num1:P2}");
        }
    }
}
