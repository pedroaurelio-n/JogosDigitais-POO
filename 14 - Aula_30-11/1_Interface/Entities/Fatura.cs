using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _1_Interface.Entities
{
    class Fatura
    {
        //variáveis com autoproperties
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        //construtor personalizado que passa os valores para as variáveis locais
        public Fatura(double aluguel, double taxa) 
        {
            PagamentoBasico = aluguel; 
            Taxa = taxa; 
        }

        //variável com propriedade customizada. no caso, a soma de PagamentoBasico + Taxa
        public double PagamentoTotal 
        {
            get { return PagamentoBasico + Taxa; }
        }
        
        //método ToString para formatar o output do objeto
        public override string ToString() 
        { 
            return "Basic payment: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTax: " 
                + Taxa.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTotalpayment: " 
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
