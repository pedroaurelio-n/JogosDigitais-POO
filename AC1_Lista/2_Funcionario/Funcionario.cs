using System;
using System.Globalization;

namespace _2_Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double PorcentagemReal = (100 + porcentagem) / 100;
            SalarioBruto =  SalarioBruto * PorcentagemReal;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n"
                + "Salário líquido: " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
