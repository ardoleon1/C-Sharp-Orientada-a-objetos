using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ContaCorrente : Conta
    {
        private double limite;

        public double Limte { get { return limite; } set { limite = value; } }
    }
}
