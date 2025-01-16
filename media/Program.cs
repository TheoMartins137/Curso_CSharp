namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a primeira nota do aluno: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva a segunda nota do aluno: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int media, num3;

            num3 = num1 + num2;
            media = num3 / 2;

            Console.WriteLine("A média do aluno é {0}", media);

        }
    }
}
