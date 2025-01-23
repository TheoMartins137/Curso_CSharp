namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Todos os pares de um intervalo");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();    
            Console.Write("Digite o final do intervalo: ");
            int final = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= final; i++)

            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
