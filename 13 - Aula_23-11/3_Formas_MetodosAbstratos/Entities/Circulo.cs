using _3_Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Formas_MetodosAbstratos.Entities
{
    class Circulo : Forma
    {
        //declaração de variável com autoproperties
        public double Raio { get; set; }

        //construtor com parâmetros próprios e herdados da superclasse
        public Circulo(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        //método Area com override que irá sobrepor o método abstrato da superclasse
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
