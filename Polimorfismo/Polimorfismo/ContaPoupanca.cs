using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ContaPoupanca : Conta
    {
        private string diaAniversario;

        public string DiaAniversario { get { return diaAniversario; } set { diaAniversario = value; } }
    }
}
