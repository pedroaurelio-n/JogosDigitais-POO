using _3_Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Formas_MetodosAbstratos.Entities
{
    //superclasse abstrata
    abstract class Forma
    {
        //declaração do enum Color com autoproperties
        public Color Color { get; set; }
        
        //construtor com parâmetro
        public Forma (Color color)
        {
            Color = color;
        }

        //método abstrato Area que será implementado a partir das sobreposições das subclasses
        public abstract double Area();
    }
}
