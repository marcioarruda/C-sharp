using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Código, Quantidade e Valor Unitário do Produto 1 (separados por espaço)");
            string[] vet1 = Console.ReadLine().Split(' ');
            int qtd1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Código, Quantidade e Valor Unitário do Produto 2 (separados por espaço)");
            string[] vet2 = Console.ReadLine().Split(' ');
            int qtd2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("   VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("==========================================");

        }
    }
}
