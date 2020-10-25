using System;
using System.Globalization;

namespace _1_ContaBancaria
{
    class ContaBancaria
    {
        int _numero;
        string _titular;
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int numero, string titular)
        {
            _numero = numero;
            _titular = titular;
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

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
            return  "\nConta   - " + _numero.ToString(CultureInfo.InvariantCulture)
                    + "\nTitular - " + _titular
                    + "\nSaldo   - R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
