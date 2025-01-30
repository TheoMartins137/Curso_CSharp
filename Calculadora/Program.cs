namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while (cont == 1)
            {
            Console.WriteLine("===============");
            Console.WriteLine("--CAlCULADORA--");
            Console.WriteLine("===============");
            Console.WriteLine();

            Console.WriteLine("Escreva o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("===================================");
            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("- [1] ADIÇÂO ");
            Console.WriteLine("- [2] SUBTRAÇÂO ");
            Console.WriteLine("- [3] MULTIPLICAÇÂO ");
            Console.WriteLine("- [4] DIVISÂO ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 1)
            {
                soma(num1, num2);
            }

            else if (resposta == 2)
            {
                sub(num1, num2);
            }

            else if (resposta == 3)
            {
                mult(num1, num2);
            }

            else
            {
                div(num1, num2);
            }

            Console.WriteLine();
            Console.WriteLine("Deseja refazer? ");
            Console.WriteLine("-[1] SIM");
            Console.WriteLine("-[2] NÃO");
            cont = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            }


        }

        static void soma(int soma, int somb)
        {
            int resultado = soma + somb;
            Console.WriteLine($"{soma} + {somb} = {resultado}");
            Console.WriteLine();
        }

        static void sub(int soma, int somb)
        {
            int resultado = soma - somb;
            Console.WriteLine($"{soma} - {somb} = {resultado}");
            Console.WriteLine();
        }

        static void mult(int soma, int somb)
        {
            int resultado = soma * somb;
            Console.WriteLine($"{soma} * {somb} = {resultado}");
            Console.WriteLine();
        }

        static void div(int soma, int somb)
        {
            int resultado = soma / somb;
            Console.WriteLine($"{soma} / {somb} = {resultado}");
            Console.WriteLine();
        }
    }
}
