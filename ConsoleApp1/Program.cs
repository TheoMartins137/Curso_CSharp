namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidade, multa;

            Console.Write("Digite a velocidade que o carro passou pelo radar: ");
            velocidade = Convert.ToInt32(Console.ReadLine());
           
            if (velocidade > 80)
            {
                multa = (velocidade - 80) * 7;
                Console.WriteLine("Você estava a {0}KM/H, sua multa está no valor de: {1}R$", velocidade, multa);
            }
            else
            {
                Console.WriteLine("Parabéns, você está em uma ótima velocidade");
            }
        }
    }
}
