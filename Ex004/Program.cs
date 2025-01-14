namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            Console.WriteLine("Escreva o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resposta = num1 / num2;
            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num2, resposta);

            resposta = num1 % num2;
            Console.WriteLine("O resto da divisão de {0} % {1} = {2}", num1, num2, resposta);

            num4 = 35f;
            resposta = num1 / num4;
            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num4, resposta);
        }
    }
}
