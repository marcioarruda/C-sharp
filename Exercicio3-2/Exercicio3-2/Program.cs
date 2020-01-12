using System;

namespace Exercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 valores inteiros, separados por espaço:");
            string[] vet = Console.ReadLine().Split(' ');

            int numMenor = 0, numMaior = 0;

            if(int.Parse(vet[0]) < int.Parse(vet[1]))
            {
                numMenor = int.Parse(vet[0]);
                numMaior = int.Parse(vet[1]);
            }
            else
            {
                numMenor = int.Parse(vet[1]);
                numMaior = int.Parse(vet[0]);
            }

            if (numMaior % numMenor == 0)
                Console.WriteLine("São Múltiplos");
            else
                Console.WriteLine("Não São Múltiplos");
                

        }
    }
}
