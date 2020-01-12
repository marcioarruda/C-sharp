using System;

namespace Exercicio1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 1000: ");
            int n = int.Parse(Console.ReadLine());

            if(n < 1 || n > 1000)
                Console.WriteLine("Número inválido!!!");

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }


        }
    }
}
