using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface.Services
{
    interface ITaxaServico
    {
        //variável Taxa na interface que recebe quantia 
        // e tem uma flexibilidade maior de valores possíveis para Taxa
        double Taxa(double quantia);
    }
}
