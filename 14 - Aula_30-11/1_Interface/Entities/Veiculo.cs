using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface.Entities
{
    class Veiculo
    {
        //variável com autoproperties
        public string Modelo { get; set; }

        //construtor personalizado que passa o modelo para a variável local
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
