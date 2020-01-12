using System;
using System.Globalization;

namespace Exercicio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Código e a Quantidade do item desejado:");
            string[] v = Console.ReadLine().Split(' ');
            int codigo = int.Parse(v[0]);
            int quant = int.Parse(v[1]);

            double total = 0;

            if (codigo == 1)
                total = quant * 4.00;
            else if (codigo == 2)
                total = quant * 4.50;
            else if (codigo == 3)
                total = quant * 5.00;
            else if (codigo == 4)
                total = quant * 2.00;
            else
                total = quant * 1.50;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
