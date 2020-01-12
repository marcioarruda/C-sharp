using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double iof = 1.06;

        public static double Converte(double c, double d)
        {
            return (c * d) * iof;
        }
    }
}
