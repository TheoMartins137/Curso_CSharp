﻿namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;
            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o gênero: ");
                genero= Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-vindo e bem-vindas ao curso de C#");
        }
    }
}
