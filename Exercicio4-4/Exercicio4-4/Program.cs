using System;
using System.Globalization;

namespace Exercicio4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de Pares a serem digitados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                int a = int.Parse(v[0]);
                int b = int.Parse(v[1]);
                double divisao = double.Parse(a.ToString("F1"),CultureInfo.InvariantCulture) / 
                                 double.Parse(b.ToString("F1"),CultureInfo.InvariantCulture);
                
                if(b == 0)
                    Console.WriteLine("Divisão Impossível!");
                else
                    Console.WriteLine(divisao.ToString("F1"),CultureInfo.InvariantCulture);

            }
        }
    }
}
