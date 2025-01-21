namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;

            Console.Write("Qual o salário do funcionario? ");
            double salario = Convert.ToInt32(Console.ReadLine());

            if (salario > 2500)
            {
                num1 = salario * 0.05;
                Console.WriteLine("O salario é de: R${0},o ajuste é de: R${1} após os ajustes ficou: {2} ", salario, num1, salario+num1);
            }
            else if (salario > 1250)
            {
                num1 = salario * 0.10;
                Console.WriteLine("O salario é de: R${0},o ajuste é de: R${1} após os ajustes ficou: {2} ", salario, num1, salario + num1);
            }
            else
            {
                num1 = salario * 0.15;
                Console.WriteLine("O salario é de: R${0},o ajuste é de: R${1} após os ajustes ficou: {2} ", salario, num1, salario + num1);
            }
        }
    }
}
