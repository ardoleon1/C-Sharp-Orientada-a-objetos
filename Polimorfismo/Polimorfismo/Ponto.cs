using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Ponto
    {
        public void RegistrarEntrada(Funcionario funcionario)
        {
            Console.WriteLine("\t\t---Registro de Entrada---");
            DateTime agora = DateTime.Now;
            string data = string.Format("{0:dd/MM/yyyy HH:mm}", agora);
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Entrada: " + data);
        }

        public void RegistrarSaida(Funcionario funcionario)
        {
            Console.WriteLine("\t\t---Registro de Saída---");
            DateTime agora = DateTime.Now.AddHours(4);
            string data = string.Format("{0:dd/MM/yyyy HH:mm}", agora);
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Entrada: " + data);
        }
    }
}
