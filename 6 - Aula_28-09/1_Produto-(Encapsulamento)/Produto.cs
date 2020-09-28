using System;
using System.Globalization;

namespace _1_Produto__Encapsulamento_
{
	class Produto
	{
		private string _nome;
		private double _preco;
		public int Quantidade { get; private set; }

		public Produto() 
		{
		}

		public Produto(string nome, double preco, int quantidade)
		{
			_nome = nome;
			_preco = preco;
			Quantidade = quantidade;
		}
		public string Nome
		{
			get { return _nome; }

			set { if (value != null && value.Length > 1)
				{
					_nome = value;
				}
			}
		}

		public double Preco
		{
			get { return _preco; }

			set { _preco = value; }
		}


		public double ValorTotalEstoque()
		{
			double total = Quantidade * _preco;
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


		public override string ToString()
		{
			return "Nome: " + _nome + "\n"
				+ "Preço: R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " unidades em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
