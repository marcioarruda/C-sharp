using System;

namespace Exercicio6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                    Console.WriteLine(i);
            }

        }
    }
}
