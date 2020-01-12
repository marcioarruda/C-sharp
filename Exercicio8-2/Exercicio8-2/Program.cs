using System;
using System.Globalization;

namespace Exercicio8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua Renda:");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.00;

            Console.WriteLine("=======================================================");
            if (renda <= 2000.00)
                imposto = 0.00;
            else if (renda <= 3000.00)
                imposto = (renda - 2000.00) * 0.08;
            else if (renda <= 4500.00)
                imposto = (renda - 3000.00) * 0.18 + 1000.00 * 0.08;
            else
                imposto = (renda - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;


            if (imposto == 0.00)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
