using _3_Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Formas_MetodosAbstratos.Entities
{
    class Retangulo : Forma
    {
        //declaração de variáveis com autoproperties
        public double Largura { get; set; }
        public double Altura { get; set; }

        //construtor com parâmetros próprios e herdados da superclasse
        public Retangulo(double largura, double altura, Color color) : base(color)
        {
            Largura = largura;
            Altura = altura;
        }

        //método Area com override que irá sobrepor o método abstrato da superclasse
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
