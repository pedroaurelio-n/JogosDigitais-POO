using System;
using System.Globalization;
using _1_Interface.Entities;
using _1_Interface.Services;

namespace _1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //input do usuário para o modelo de carro, data-hora de início e data-hora do final do aluguel
            Console.WriteLine("Entre com os dados de locação: ");
            Console.Write("Modelo: "); 
            string modelo = Console.ReadLine(); 

            Console.Write("Check-in (dd/MM/yyyyHH:mm): "); 
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check-out (dd/MM/yyyyHH:mm): "); 
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 

            //input do usuário para o valor por hora e valor por dia
            Console.Write("Entre com o preço por hora: "); 
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.Write("Entre com o preço por dia: "); 
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            //criar um objeto AluguelCarro novo que irá receber as datas de início e fim
            //objeto recebe também o modelo criando um objeto Veiculo desse modelo dentro da criação do AluguelCarro
            AluguelCarro aluguelCarro = new AluguelCarro(inicio, fim, new Veiculo(modelo));

            //criar um objeto ServicoAluguel novo que irá receber os valores de preço por hora e preço por dia
            //dentro da criação do ServicoAluguel, é criado um objeto da classe TaxaServicoBrasil em branco
            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBrasil());

            //realizar os cálculos para a fatura com o método ProcessarFatura da classe ServicoAluguel
            //utilizando o objeto AluguelCarro criado
            servicoAluguel.ProcessarFatura(aluguelCarro); 
            
            //output da fatura já formatada pelo ToString
            Console.WriteLine("FATURA:"); 
            Console.WriteLine(aluguelCarro.Fatura);

            Console.ReadKey();
        }
    }
}
