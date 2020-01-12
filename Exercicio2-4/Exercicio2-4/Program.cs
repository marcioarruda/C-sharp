using System;

namespace Exercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0, num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                    dentro += 1;
                else
                    fora += 1;
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}
