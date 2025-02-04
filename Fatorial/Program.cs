namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char resp;
            bool mostrar = false;

            Console.Write("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Deseja mostrar os cálculos? (S/N)");
            resp =  Convert.ToChar(Console.ReadLine().ToUpper());

            if (resp == 'S') { mostrar = true; }

            Console.WriteLine(fatorial(num, mostrar));
         
        }

        static int fatorial(int n, bool show =  false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.Write(i);
                    if (i < n)
                    {
                        Console.Write(" X ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }

                f *= i;
            }
            return f;
        }
    }
}
