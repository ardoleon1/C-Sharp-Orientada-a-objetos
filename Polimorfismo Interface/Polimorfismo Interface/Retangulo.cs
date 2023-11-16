using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Interface
{
    public class Retangulo : IAreaCalculavel
    {
        private double comprimento, largura;
        public double Comprimento { get => comprimento; set => comprimento = value; }
        public double Largura { get => largura; set => largura = value; }
        public double calcularArea()
        {
            return comprimento * largura;
        }
    }
}
