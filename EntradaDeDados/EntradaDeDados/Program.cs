using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma saldação: ");
            string frase = Console.ReadLine();
            Console.Write("Digite a primeira cor: ");
            string x = Console.ReadLine();
            Console.Write("Digite a segunda cor: ");
            string y = Console.ReadLine();
            Console.Write("Digite a terceira cor: ");
            string z = Console.ReadLine();

            // neste caso receberá 3 palavras e vai dividir por palavra
            Console.Write("Digite 3 cores diferentes na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            // armazenando cada palavra em uma variável diferente
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Variável frase: " + frase);
            Console.WriteLine("Variável x: " + x);
            Console.WriteLine("Variável y: " + y);
            Console.WriteLine("Variável z: " + z);
            Console.WriteLine("Variável a: " + a);
            Console.WriteLine("Variável b: " + b);
            Console.WriteLine("Variável c: " + c);

            // segunda parte
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Segunda parte");

            Console.Write("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite uma letra: ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Digite um número com ponto flutuante: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Variável n1: " + n1);
            Console.WriteLine("Variável ch: " + ch);
            Console.WriteLine("Variável n2: " + n2);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Digite um Nome, o Sexo (F ou M), a Idade e a Altura separados por um espaço:");
            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine("Variável nome: " + nome);
            Console.WriteLine("Variável sexo: " + sexo);
            Console.WriteLine("Variável idade: " + idade);
            Console.WriteLine("Variável altura: " + altura);


        }
    }
}
