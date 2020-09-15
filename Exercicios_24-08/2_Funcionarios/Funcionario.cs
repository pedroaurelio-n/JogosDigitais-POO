using System;

namespace POO___Aula_1___Ex3
{
    class Funcionario
    {
        public string nome;
        public float salario;

        public double SalarioMedia()
        {
            double salario_media = (salario) / 2;
            return salario_media;
        }
    }
}

