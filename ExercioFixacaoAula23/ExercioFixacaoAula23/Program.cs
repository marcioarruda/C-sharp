using System;

namespace ExercioFixacaoAula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o salda da tua conta bancária:");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha, separado por espaço):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 DADOS DIGITADOS ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("  Nome Completo: " + nome);
            Console.WriteLine("  Quantidade de Quartos: " + quartos);
            Console.WriteLine("  Saldo Bancário: " + saldo.ToString("F2"));
            Console.WriteLine("  Último Nome: " + ultimoNome);
            Console.WriteLine("  Idade: " + idade);
            Console.WriteLine("  Altura: " + altura.ToString("F2"));
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}
