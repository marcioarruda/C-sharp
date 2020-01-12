using System;

namespace Exercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Hora Inicial e Final do jogo, separadas por espaço: ");
            string[] v = Console.ReadLine().Split(' ');
            
            int horaIni = int.Parse(v[0]);
            int horaFin = int.Parse(v[1]);

            if(horaIni < horaFin)
                Console.WriteLine("O JOGO DUROU " + (horaFin - horaIni) + " HORA(S)");
            else
                Console.WriteLine("O JOGO DUROU " + ((24 - horaIni) + horaFin) + " HORA(S)");

        }
    }
}
