namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soma(3, 4);
            ola("Theo");
        }


        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine(resultado);
        }

        static void ola(string nome)
        {
            Console.WriteLine(nome + ". Seja Bem-Vindo!");
        }
    }
}
