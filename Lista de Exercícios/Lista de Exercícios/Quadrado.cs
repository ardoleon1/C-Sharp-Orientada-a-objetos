using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    public class Quadrado
    {
        public double lado;

        public Quadrado (double lado)
        {
            this.lado = lado;
        }

        public void MudarValorLado(double valor)
        {
            lado = valor;
        }
        public double CalcularPerimetro()
        {
            double total = lado + lado + lado + lado;
            return total;
        }
        public double CalcularArea()
        {
            double total = lado * lado;
            return total;
        }
    }
}
