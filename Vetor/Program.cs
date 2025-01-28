namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[3]);

            int[] n = new int[3] { 1, 2, 3 };
            Console.WriteLine(n[2]);

            int[] n2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(n2[i]);
            }

            double[] reais = { 4.1, 2.8, 2.4, 7.0, 9.12, 34.9, 90.87 };

            for (int i = 0; i < reais.Length; i++)
            {
                Console.WriteLine(reais[i]);
            }

            double reais_maior = reais.Max();
            double reais_menor = reais.Min();
            */

            string[] nomes = { "Jones", "Carlos", "Maria", "Ana", "zeferina" };

            for(int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.WriteLine(nomes[i] + ".");
                }
            }

            Console.WriteLine();
            string nome_primeiro = nomes.First();
            string nome_ultimo = nomes.Last();
            Console.WriteLine("O primeiro nome é : " + nome_primeiro);
            Console.WriteLine("O ultimo nome é : " + nome_ultimo);
            Console.WriteLine();
            string nomes_maior = nomes.Max();
            string nomes_menor = nomes.Min();
            Console.WriteLine("O primeiro nome em ordem alfabética: " + nomes_menor);
            Console.WriteLine("O ultimo nome em ordem alfabética: " + nomes_maior);
        }
    }
}
