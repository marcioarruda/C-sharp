using System;
using System.Globalization;

namespace Exercicio3Aula45Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.CalculaNotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.Resultado());

            if (a.Resultado() == "REPROVADO")
                Console.WriteLine("FALTARAM " 
                    + a.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");

        }
    }
}
