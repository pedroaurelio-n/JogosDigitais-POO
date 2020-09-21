using System;

namespace POO_31_8_Ex1
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
	}
}

