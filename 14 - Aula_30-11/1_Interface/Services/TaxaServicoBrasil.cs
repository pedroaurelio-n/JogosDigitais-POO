using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface.Services
{
    class TaxaServicoBrasil : ITaxaServico
    {
        //TaxaServicoBrasil é uma classe que herda informações da interface ITaxaServico
        //então precisa ter um método Taxa para sobrescrever o método padrão da interface
        public double Taxa(double quantia) 
        { 
            //se a quantia for menor ou igual a 100, a taxa é 20% de quantia
            if (quantia <= 100.00) 
            { 
                return quantia * 0.2; 
            }

            //se a quantia for maior que 100, a taxa é 15% de quantia
            else
            { 
                return quantia * 0.15; 
            } 
        }
    }
}
