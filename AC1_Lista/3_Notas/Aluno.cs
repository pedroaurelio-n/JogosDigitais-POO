using System;

namespace _3_Notas
{
    class Aluno
    {
        public string Nome;
        public float Nota1;
        public float Nota2;
        public float Nota3;

        public double NotaFinal;

        public Aluno (string nome, float nota1, float nota2, float nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double GerarNotaFinal()
        {
            NotaFinal = Nota1 + Nota2 + Nota3;
            return NotaFinal;
        }
    }
}
