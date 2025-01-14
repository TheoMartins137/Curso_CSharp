namespace tabuadareal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o número que deseja ter a tabuada: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} X 1 = {1}", num1, num1 * 1);
            Console.WriteLine("{0} X 2 = {1}", num1, num1 * 2);
            Console.WriteLine("{0} X 3 = {1}", num1, num1 * 3);
            Console.WriteLine("{0} X 4 = {1}", num1, num1 * 4);
            Console.WriteLine("{0} X 5 = {1}", num1, num1 * 5);
            Console.WriteLine("{0} X 6 = {1}", num1, num1 * 6);
            Console.WriteLine("{0} X 7 = {1}", num1, num1 * 7);
            Console.WriteLine("{0} X 8 = {1}", num1, num1 * 8);
            Console.WriteLine("{0} X 9 = {1}", num1, num1 * 9);
            Console.WriteLine("{0} X 10 = {1}", num1, num1 * 10);

        }
    }
}
