using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Interface
{
    public class Quadrado : IAreaCalculavel
    {
        private double lado;
        public double Lado { get => lado; set => lado = value; }
        public double calcularArea()
        {
            return lado * lado;
        }
    }
}
