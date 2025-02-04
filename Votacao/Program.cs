namespace Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasce;
            Console.Write("Digite o ano do seu nascimento: ");
            nasce = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(voto(nasce));
        }

        static string voto (int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = anoAtual - ano;

            if (idade < 16)
            {
                return $"Com {idade} anos, você não vota!";
            }
            else if (idade > 18 && idade < 70)
            {
                return $"Com {idade} anos, seu voto é OBRIGATÓRIO!";
            }
            else
            {
                return $"Com {idade} anos, seu voto é OPCIONAL!";

            }
        }
    }
}
