using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ContaCorrente : Conta, IGeradorDeExtrato
    {
        private double limiteEspecial;

        public double LimteEspecial { get { return limiteEspecial; } set { limiteEspecial = value; } }

        public void GerarExtrato()
        {
            Console.WriteLine("Gerando extrato...");
        }
    }
}
