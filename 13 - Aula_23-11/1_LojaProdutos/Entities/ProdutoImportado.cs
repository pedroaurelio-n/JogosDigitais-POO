using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1_LojaProdutos.Entities
{
    class ProdutoImportado : Produto
    {
        //declaração de variável com propriedades autoimplementadas
        public double Taxa { get; private set; }

        //construtor padrão
        public ProdutoImportado() { }

        //construtor com um parâmetro próprio e com o resto deles herdados da classe base
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Taxa = taxa;
        }

        //método que calcula o preço total
        public double PrecoTotal()
        {
            return Preco + Taxa;
        }

        //método que retorna uma string que sobrepõe o método de mesmo nome da classe base
        public override string PrecoTag()
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Taxa: R$" + Taxa + ")";
        }
    }
}
