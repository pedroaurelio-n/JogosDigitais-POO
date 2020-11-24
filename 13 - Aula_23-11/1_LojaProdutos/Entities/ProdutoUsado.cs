using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1_LojaProdutos.Entities
{
    class ProdutoUsado : Produto
    {
        //declaração de variável com propriedades autoimplementadas
        public DateTime Fabricacao { get; private set; }

        //construtor padrão
        public ProdutoUsado() { }

        //construtor com um parâmetro próprio e com o resto deles herdados da classe base
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }

        //método que retorna uma string que sobrepõe o método de mesmo nome da classe base
        public override string PrecoTag()
        {
            return Nome + " (usado) - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Fabricado: " + Fabricacao.ToString("dd/MM/yy") + ")";
        }
    }
}
