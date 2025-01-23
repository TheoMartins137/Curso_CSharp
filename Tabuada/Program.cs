namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2} ", num1,i, num1 * i);
            }
        }
    }
}
