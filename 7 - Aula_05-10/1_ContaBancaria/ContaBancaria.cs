using System;
using System.Globalization;

namespace _1_ContaBancaria
{
    class ContaBancaria
    {
        int _numero;
        string _titular;
        double _saldo;

        public ContaBancaria()
        {
        }

        public ContaBancaria(int numero, string titular, double saldo)
        {
            _numero = numero;
            _titular = titular;
            _saldo = saldo;
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

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
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
