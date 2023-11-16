using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ContaPoupanca : Conta
    {
        private int dtAniversario;

        public int DtAniversario { get { return dtAniversario; } set { dtAniversario = value; } }
    }
}
