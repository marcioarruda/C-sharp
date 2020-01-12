using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
