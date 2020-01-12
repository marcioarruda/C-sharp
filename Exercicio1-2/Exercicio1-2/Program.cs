using System;

namespace Exercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("==================================");
            
            if (num >= 0)
                Console.WriteLine("   NAO NEGATIVO");
            else
                Console.WriteLine("   NEGATIVO");
            
            Console.WriteLine("==================================");

        }
    }
}
