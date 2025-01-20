namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            double n2;
         

            Console.Write("QUal valor você deseja saber se é par ou impar? ");
            n1 = Convert.ToInt32(Console.ReadLine());

            n2 = n1 % 2;

            if (n2 == 0)
            {
                Console.WriteLine("Seu número é par");
            }
            else
            {
                Console.WriteLine("Seu número é impar");
            }
        }
    }
}
