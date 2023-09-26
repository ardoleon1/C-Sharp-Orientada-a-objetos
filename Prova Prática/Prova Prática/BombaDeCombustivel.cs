using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Prática
{
    public class BombaDeCombustivel
    {
        private string tipoCombustivel;
        private double valorLitro;
        private double quantidadeCombustivel;

        public string TipoCombustivel { get; set; }
        public double ValorLitro { get; set; }
        public double QuantidadeCombustivel 
        { 
            get
            {
                return quantidadeCombustivel;
            }
            set
            {
                if (value > 0)
                {
                    quantidadeCombustivel = value;
                }
                else
                {
                    Console.WriteLine("Valor inválido...");
                }
            }
        }

        public BombaDeCombustivel(string tipoCombustivel, double valorLitro, double quantidadeCombustivel)
        {
            TipoCombustivel = tipoCombustivel;
            ValorLitro = valorLitro;
            QuantidadeCombustivel = quantidadeCombustivel;
        }
        public void AbastecerPorValor(double valor)
        {
            double total = valor / ValorLitro;
            Console.WriteLine("Operação realizada! Foi retirado " + total + " litros!");
            QuantidadeCombustivel = QuantidadeCombustivel - total;
            Console.WriteLine("Quantidade de Combustível disponível: " + QuantidadeCombustivel);
        }
        public void AbastecerPorLitro(double valor)
        {
            double total = valor * ValorLitro;
            Console.WriteLine("Operação realizada! Valor total é " + total.ToString("c2"));
            QuantidadeCombustivel = QuantidadeCombustivel - total;
            Console.WriteLine("Quantidade de Combustível disponível: " + QuantidadeCombustivel);
        }
        public void alterarValor(double valor)
        {
            ValorLitro = valor;
        }
        public void alterarCombustivel(string nome)
        {
            TipoCombustivel = nome;
            Console.WriteLine("Agora o tipo de Combustível é " + TipoCombustivel);
        }
        public void alterarQuantidadeCombustivel(double valor)
        {
            QuantidadeCombustivel = valor;
            Console.WriteLine("Agora a quantidade de Combustível é " + QuantidadeCombustivel);
        }
    }
}
