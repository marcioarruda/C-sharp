﻿using System;

namespace Exercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as Coordenadas X e Y separadas por espaço: ");
            string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);

            while (x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if(x < 0 && y >= 0)
                    Console.WriteLine("Segundo");
                else if(x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else
                    Console.WriteLine("Quarto");

                v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);
            }

        }
    }
}
