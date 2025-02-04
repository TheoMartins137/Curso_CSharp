namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contagem(1, 10, 1);
            Console.WriteLine();
            contagem(10, 0, 2);
            Console.WriteLine();
            Escrever("Agora é a sua vez de fazer a contagem");
            Console.Write("Digite o início da contagem: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o fim da contagem: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o passo da contagem: ");
            int pass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            contagem(ini, fim, pass);

        }

        static void contagem (int i, int f, int p)
        {
            Escrever($"Contagem de {i} até {f} ao passo {p}");

            
            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont += p;
                }
           
            }
            else
            {
                int cont = i;
                while (cont >= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont -= p;
                }
               
            }
        }

        static void Escrever (string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine($"{textoCentralizado}");
            Console.WriteLine(linha);
        }
    }
}
