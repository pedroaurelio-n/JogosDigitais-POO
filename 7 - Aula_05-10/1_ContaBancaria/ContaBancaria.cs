using System;
using System.Globalization;

namespace _1_ContaBancaria
{
    class ContaBancaria
    {
        //declaração de variáveis com autoproperties
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //construtor padrão
        public ContaBancaria()
        {
        }

        //construtor personalizado
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //métodos de classe pra depositos e saques
        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
        }

        public void RealizarSaque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return  "\nConta   - " + Numero.ToString(CultureInfo.InvariantCulture)
                    + "\nTitular - " + Titular
                    + "\nSaldo   - R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
