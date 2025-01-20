namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km;
            double valor;

            Console.Write("Qual a distância da viagem? ");
            km = Convert.ToDouble(Console.ReadLine());

            if (km <= 200)
            {
                valor = km * 0.50;
                Console.Write("O valor a ser pago é de: {0}R$", valor);
            }
            else
            {
                valor = km * 0.45;
                Console.Write("O valor a ser pago é de: {0}R$", valor);
            }
        }
    }
}
