using System;

namespace Exercicio5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;
            
            for(int i = 1; i <= N; i++)
            {
                fatorial *= i;
            }

            if (N == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(fatorial);

        }
    }
}
