using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Interface
{
    public class Circulo : IAreaCalculavel
    {
        private double raio;
        public double Raio { get => raio; set => raio = value; }
        public double calcularArea()
        {
            return Math.PI * (raio * raio);
        }
    }
}
