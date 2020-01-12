using System;

namespace Exercicio7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3));
            }
        }
    }
}
