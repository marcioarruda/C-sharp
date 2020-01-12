using System;
using System.Globalization;

namespace Exercicio3Aula45Classes
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculaNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            if (CalculaNotaFinal() >= 60)
                return "APROVADO";
            else
                return "REPROVADO";
        }

        public double PontosFaltantes()
        {
            return 60.0 - CalculaNotaFinal();            
        }
    }
}
