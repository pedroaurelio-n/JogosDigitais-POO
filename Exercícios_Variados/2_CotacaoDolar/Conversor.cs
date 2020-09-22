using System;

namespace _2_CotacaoDolar
{
    class Conversor
    {
        public static double Taxa_IOF = 1.06;

        public static double ConverterMoeda(double cotacao, double quantidade)
        {
            return cotacao * quantidade * Taxa_IOF;
        }
    }
}
