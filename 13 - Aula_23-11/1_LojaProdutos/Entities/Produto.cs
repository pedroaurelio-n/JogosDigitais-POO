using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1_LojaProdutos.Entities
{
    class Produto
    {
        //declaração de variáveis com propriedades autoimplementadas
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        //construtor padrão
        public Produto() { }

        //construtor com parâmetros
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //método virtual que retorna uma string mostrando as informações. se o objeto for comum, esta string é mostrada
        //se for um objeto de uma subclasse, esse método será sobreposto com um outro método dessas subclasses utilizando o override
        public virtual string PrecoTag()
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
