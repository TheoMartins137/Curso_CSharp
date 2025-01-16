namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num2 = 1;

            Console.WriteLine("Escreva um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            while (num2 < 11)
            {
                Console.WriteLine("{0} vezes {1} = {2}", num1, num2, num1*num2);
                num2++;


            }
        }
    }
}
