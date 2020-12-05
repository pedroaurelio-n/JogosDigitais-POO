using System;
using System.Collections.Generic;
using System.Text;
using _1_Interface.Entities;

namespace _1_Interface.Services
{
    class ServicoAluguel
    {
        //variáveis com autoproperties
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }
        
        //variavel 
        private ITaxaServico _taxaServico;

        //construtor personalizado que passa os valores para as variáveis locais
        public ServicoAluguel(double precoHora, double precoDia, ITaxaServico taxaServico) 
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _taxaServico = taxaServico; 
        }
        
        //método que realiza os calculos da fatura
        public void ProcessarFatura(AluguelCarro aluguelCarro) 
        { 
            //calculo da duração do aluguel
            TimeSpan duracao = aluguelCarro.Fim.Subtract(aluguelCarro.Inicio); 

            //declaração de pagamentoBasico
            double pagamentoBasico = 0.0; 

            //se a duração for menor que 12 horas, o pagamentoBasico se equivale ao preço por hora x total de horas
            if (duracao.TotalHours <= 12.0) 
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours); 
            } 
            
            //se a duração for maior que 12 horas, pagamentoBasico se equivale ao preço por dia x total de dias
            else 
            {
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays); 
            } 
            
            //criar variável taxa que será a taxa de serviço do pagamentoBasico utilizando a interface
            double tax = _taxaServico.Taxa(pagamentoBasico);

            //criar objeto Fatura que recebe o pagamentoBasixo e a taxa e armazena na variável fatura do objeto AluguelCarro
            aluguelCarro.Fatura = new Fatura(pagamentoBasico, tax); 
        }
    }
}
