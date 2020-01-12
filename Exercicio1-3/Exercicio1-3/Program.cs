using System;

namespace Exercicio1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua Senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite sua Senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
