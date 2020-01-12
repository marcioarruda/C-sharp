using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converte(cotacao,qtDolares).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
