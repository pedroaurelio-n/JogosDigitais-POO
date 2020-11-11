using System;
using System.Globalization;

namespace _1_Produto__Encapsulamento_
{
	class Produto
	{
		//declaração de variáveis, duas com propriedades autoimplementadas
		private string _nome;
		public double Preco { get; private set; }
		public int Quantidade { get; private set; }

		//construtor padrão
		public Produto() 
		{
		}

		//construtor personalizado
		public Produto(double preco, int quantidade)
		{
			Preco = preco;
			Quantidade = quantidade;
		}

		//propriedade Nome customizada com condição
		public string Nome
		{
			get { return _nome; }

			set { if (value != null && value.Length > 1)
				{
					_nome = value;
				}
			}
		}

		//métodos de classe
		public double ValorTotalEstoque()
		{
			double total = Quantidade * Preco;
			return total;
		}

		public void AdicionarProdutos(int qnt)
		{
			Quantidade += qnt;
		}

		public void RemoverProdutos(int qnt)
		{
			Quantidade -= qnt;
		}

		//tostring para definir a formatação
		public override string ToString()
		{
			return "Nome: " + _nome + "\n"
				+ "Preço: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " unidades em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
