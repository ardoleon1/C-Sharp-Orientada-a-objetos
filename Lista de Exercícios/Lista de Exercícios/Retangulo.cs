using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    public class Retangulo
    {
        public double ladoA, ladoB;

        public Retangulo(double ladoA, double ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }
        public void MudarLadoA(double valor)
        {
            ladoA = valor;
        }
        public void MudarLadoB(double valor)
        {
            ladoB = valor;
        }
        public double CalcularPerimetro()
        {
            double total = ladoA * 2 + ladoB * 2;
            return total;
        }
        public double CalcularArea()
        {
            double total = ladoA * ladoB;
            return total;
        }
    }
}
