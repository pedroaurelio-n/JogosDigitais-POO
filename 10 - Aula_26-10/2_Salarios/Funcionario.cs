using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _2_Salarios
{
    class Funcionario
    {
        //declaração de variáveis, id com propriedades autoimplementadas
        public int Id { get; private set; }
        private string _nome;
        private double _salario;

        //construtor padrão
        public Funcionario()
        {
        }

        //construtor personalizado que atribui os valores para Id e _nome
        public Funcionario(int id, string nome)
        {
            Id = id;
            _nome = nome;
        }

        //variável publica Salario com propriedades customizadas
        public double Salario
        {
            get { return _salario; }

            //se o valor de Salário do objeto for o padrão, o usuário modificará-o somente na primeira vez
            //quaisquer modificações futuras serão feitas por meio de métodos
            set
            { if (_salario == default)
                    {
                        _salario = value;
                    } 
            }
        }

        //método público para aumentar o salário
        //ele multiplica o valor atual do salário por 100 + (porcentagem digitada pelo usuário), tudo dividido por 100 para chegar no decimal correto
        //ex: aumento de 40% = (100 + 40)/100 = 1.4
        public void AumentarSalario(double porcentagem)
        {
            _salario *= (100 + porcentagem) / 100;
        }

        //método tostring para o programa mostrar a formatação correta na hora de exibir os objetos da classe Funcionario
        public override string ToString()
        {
            return Id.ToString("000")
                + ", " + _nome
                + ", R$ " + _salario;
        }
    }
}
