using System;
using System.Globalization;

namespace _1_Produto__ToString_
{
	public class Produto
	{
		public string Nome;
		public double Preco;
		public int Quantidade;

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


		public override string ToString()
		{
			return "Nome: " + Nome + "\n"
				+ "Preço: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " unidades em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
