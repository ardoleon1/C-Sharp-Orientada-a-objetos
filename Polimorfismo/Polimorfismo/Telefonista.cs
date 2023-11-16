using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Telefonista : Funcionario
    {
        public override void AtualizarDados()
        {
            Console.WriteLine("Atualizando dados da telefonista...");
        }
    }
}
