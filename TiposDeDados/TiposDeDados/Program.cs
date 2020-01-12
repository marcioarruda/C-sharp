using System;
using System.Globalization; // necessário para utilizar o CultureInfo.InvariantCulture

namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 100;
            int n3 = 2147483647;
            long n4 = 2147483648L; //quando usar um valor explicito do tipo long colocar um L no final
            float n5 = 4.5f; //float precisa usar o f no final do número
            double n6 = 4.5;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; //char pode receber também o codigo unicode do caracter desejado
            string nome = "Maria Green";
            int idade = 23;         
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            sbyte n10 = sbyte.MaxValue;
            decimal n11 = decimal.MaxValue;

            double saldo = 10.35784;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("Valor mínimo do int é " + n7);
            Console.WriteLine("Valor máximo do int é " + n8);
            Console.WriteLine("Valor mínimo do sbyte é " + n9);
            Console.WriteLine("Valor máximo do sbyte é " + n10);
            Console.WriteLine("Valor máximo do decimal é " + n11);
            Console.WriteLine("------------------------------");
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2") + " Saldo com duas casas decimais");
            Console.WriteLine(saldo.ToString("F3") + " Saldo com três casas decimais");
            // para imprimir ponto no lugar da vírgula
            // é necessário declarar using System.Globalization para usar o CultureInfo.InvariantCulture
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------");
            // placeholder
            Console.WriteLine("{0} tem {1} anos e possui {2:F2} de saldo.", nome, idade, saldo);
            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e possui {saldo:F2} de saldo.");
            // concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e possui " + saldo.ToString("F2") + " de saldo.");
        }
    }
}
