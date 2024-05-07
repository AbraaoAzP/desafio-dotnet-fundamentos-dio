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
            Console.WriteLine("Digite a placa do veículo a ser estacionado:");

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

            string placaSaida = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaSaida.ToUpper()))
            {
                
                int horas = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

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

                // for(int contador = 0; contador < veiculos.Count; contador++)
                // {
                //     Console.WriteLine(veiculos[contador]);
                // }

                foreach(string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}