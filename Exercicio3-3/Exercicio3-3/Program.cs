using System;

namespace Exercicio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código do Combustível: ");
            int cod = int.Parse(Console.ReadLine());
            int a = 0, g = 0, d = 0;

            while (cod != 4)
            {
                if (cod == 1)
                    a += 1;
                else if (cod == 2)
                    g += 1;
                else if (cod == 3)
                    d += 1;
                
                Console.Write("Digite o código do Combustível: ");
                cod = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("=================================================");
            Console.WriteLine("  MUITO OBRIGADO");
            Console.WriteLine("  Alcool   : " + a);
            Console.WriteLine("  Gasolina : " + g);
            Console.WriteLine("  Diesel   : " + d);
            Console.WriteLine("=================================================");

        }
    }
}
