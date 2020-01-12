using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do funcionário: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = horas * valorHora;

            Console.WriteLine("================================");
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("================================");

        }
    }
}
