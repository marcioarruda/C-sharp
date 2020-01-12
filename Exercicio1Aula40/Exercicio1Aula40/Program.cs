using System;

namespace Exercicio1Aula40
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeira, segunda;
            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeira.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segunda.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.Idade = int.Parse(Console.ReadLine());

            if (primeira.Idade > segunda.Idade)
                Console.WriteLine("Pessoa mais velha: " + primeira.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + segunda.Nome);

        }
    }
}
