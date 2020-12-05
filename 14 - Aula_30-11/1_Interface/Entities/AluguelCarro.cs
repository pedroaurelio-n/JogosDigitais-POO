using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface.Entities
{
    class AluguelCarro
    {
        //variáveis com autoproperties
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; } 
        
        //construtor personalizado
        //além de dar valores pras variáveis locais, a fatura fica nula quando um objeto novo é criado
        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo) 
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            Fatura = null; 
        }
    }
}
