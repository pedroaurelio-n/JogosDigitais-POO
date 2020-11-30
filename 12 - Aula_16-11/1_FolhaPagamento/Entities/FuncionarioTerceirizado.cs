using System;
using System.Collections.Generic;
using System.Text;

namespace _1_FolhaPagamento.Entities
{
    //subclasse de Funcionario
    class FuncionarioTerceirizado : Funcionario
    {
        //declaração de variável com autoproperties
        public double Adicional { get; private set; }

        //construtor padrão
        public FuncionarioTerceirizado() { }

        //construtor da subclasse com parâmetro customizado próprio e outros herdados da superclasse
        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double adicional) : base (nome, horas, valorHora)
        {
            Adicional = adicional;
        }

        //método de pagamento que calcula o total pago para um funcionário terceirizado por meio da multiplicação do valor por hora x horas e depois somados por 110% do valor adicional
        //possui override pois irá sobrepor o método de mesmo nome da superclasse já que o cálculo é diferente
        public override double Pagamento()
        {
            return (ValorHora * Horas) + 1.1 * Adicional;
        }
    }
}
