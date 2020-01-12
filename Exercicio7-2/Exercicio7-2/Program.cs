using System;
using System.Globalization;

namespace Exercicio7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números com uma casa decimal (Positivos e Negativos):");
            string[] v = Console.ReadLine().Split(' ');
            double x = double.Parse(v[0], CultureInfo.InvariantCulture);
            double y = double.Parse(v[1], CultureInfo.InvariantCulture);

            if(x == 0.0 && y == 0.0)
                Console.WriteLine("Origem");
            else if (x == 0.0)
                Console.WriteLine("Eixo Y");
            else if (y == 0.0)
                Console.WriteLine("Eixo X");
            else if (x > 0.0 && y > 0.0)
                Console.WriteLine("Q1");
            else if (x > 0.0 && y < 0.0)
                Console.WriteLine("Q4");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q2");
        }
    }
}
