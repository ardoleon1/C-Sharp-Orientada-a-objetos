using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomba_de_Combustível
{
    public class bombaCombustível
    {
        public string tipoCombustivel;
        public double valorLitro;
        public double quantidadeCombustivel;

        public void abastecerPorValor(double valor)
        {
            double total = valor / valorLitro;
            Console.WriteLine("Quantidade de litros: " + total);
            quantidadeCombustivel = quantidadeCombustivel - total;
        }
        public void abastecerPorLitro(double valor)
        {
            double total = valor * valorLitro;
            Console.WriteLine("Valor total: " + total);
            quantidadeCombustivel = quantidadeCombustivel - total;
        }
        public void alterarValor(double valor)
        {
            valorLitro = valor;
        }
        public void alterarCombustivel(string nome)
        {
            tipoCombustivel = nome;
        }
        public void alterarQuantidadeCombustivel(double valor)
        {
            quantidadeCombustivel = valor;
        }
    }
}
