using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Conta
    {
        private int numero;
        private double saldo;
        private double limite;

        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
    }
}
