namespace Teste_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if (tentativas >3 ) { break; }
            }while (senhaDigitada != senha);

            if (senhaDigitada != senha)
            {
                Console.Clear();
                Console.WriteLine("Senha incorreta!   Tentativas: " + tentativas);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha correta!  Tentativas: " + tentativas);
            }
        }
    }
}
