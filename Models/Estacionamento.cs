using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentosDOTNET.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo a ser estacionado:");

            // IMPLEMENTAÇÃO:
            string placaEntrada = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaEntrada.ToUpper()))
            {
                Console.WriteLine("O veículo informado já está estacionado! Verifique a placa e tente novamente.");
            }
            else
            {
                veiculos.Add(placaEntrada);
                Console.Write("Veículo estacionado com sucesso!\n");
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");

            // TODO: Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTAR AQUI*

            // IMPLEMENTAÇÃO:
            string placaSaida = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaSaida.ToUpper()))
            {
                
                int horas = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                // *IMPLEMENTE AQUI*

                //IMPLEMENTAÇÃO:
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                //IMPLEMENTAÇÃO:
                veiculos.Remove(placaSaida);

                Console.WriteLine($"O veículo {placaSaida} foi removido e o preço total a ser pago é de: R${valorTotal.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não encontra-se estacionado aqui. Confira se a placa informada está correta.");
            }    
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                //IMPLEMENTAÇÃO:

                for(int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine(veiculos[contador]);
                }

                // foreach(string item in veiculos)
                // {
                //     Console.WriteLine(item);
                // }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}