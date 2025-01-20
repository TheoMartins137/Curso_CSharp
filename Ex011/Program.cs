namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Console.Write("Qual o primeiro lado do triângulo?");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o segundo lado do triângulo?");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o terceiro lado do triângulo?");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n2 + n1)
            {
                Console.WriteLine("Seu triângulo é válido");
            }

            else
            {
                Console.WriteLine("Seu triângulo é inválido");
                return;
            }            

            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("Seu triângulo é equilátero");
            }
            else if (n1 == n2 && n2 != n3 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Seu triângulo é isósceles");
            }
            else
            {
                Console.WriteLine("Seu triângulo é escaleno");
            }
        }
    }
}
