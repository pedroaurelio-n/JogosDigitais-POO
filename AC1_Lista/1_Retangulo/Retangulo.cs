using System;

namespace _1_Retangulo
{
    class Retangulo
    {
        public static double Area(double largura, double altura)
        {
            return largura * altura;
        }

        public static double Perimetro(double largura, double altura)
        {
            return 2 * largura + 2 * altura;
        }

        public static double Diagonal(double largura, double altura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
