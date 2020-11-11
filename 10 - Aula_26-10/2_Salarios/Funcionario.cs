using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _2_Salarios
{
    class Funcionario
    {
        public int Id { get; private set; }
        private string _nome;
        private double _salario;

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome)
        {
            Id = id;
            _nome = nome;
        }

        public double Salario
        {
            get { return _salario; }

            set { if (_salario == default)
                    {
                        _salario = value;
                    } 
            }
        }

        public void AumentarSalario(double porcentagem)
        {
            _salario *= (100 + porcentagem) / 100;
        }


        public override string ToString()
        {
            return Id.ToString("000")
                + ", " + _nome
                + ", R$ " + _salario;
        }
    }
}
