using System;
using System.Globalization;

namespace Exercicio2Aula45Classes
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double p)
        {
            SalarioBruto += (SalarioBruto * p) /100;
        }
    }
}
