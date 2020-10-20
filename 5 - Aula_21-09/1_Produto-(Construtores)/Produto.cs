using System;
using System.Globalization;

namespace _1_Produto__Construtores_
{
	public class Produto
	{
		//variáveis públicas principais
		public string Nome;
		public double Preco;
		public int Quantidade;

		//construtor de classe que recebe parâmetros que serão atribuidos nas variáveis principais, e garantem o não recebimento de dados nulos na criação de um objeto
		public Produto (string nome, double preco, int quantidade)
		{
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}

		//método pra calcular o valor total do estoque
		public double ValorTotalEstoque()
		{
			double total = Quantidade * Preco;
			return total;
		}

		//métodos pra modificar a quantidade de produtos
		public void AdicionarProdutos(int qnt)
		{
			Quantidade += qnt;
		}

		public void RemoverProdutos(int qnt)
		{
			Quantidade -= qnt;
		}

		//método ToString pra ter uma formatação adequada quando precisar mostrar a informação
		public override string ToString()
		{
			return "Nome: " + Nome + "\n"
				+ "Preço: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " unidades em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}