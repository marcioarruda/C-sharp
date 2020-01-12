using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro para A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro para B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro para C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro para D:");
            int D = int.Parse(Console.ReadLine());

            int dif = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + dif);

        }
    }
}
