using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            func.Nome = "Andressa";
            func.Salario = 2500;

            Console.WriteLine(func.Nome);
            Console.WriteLine(func.Salario);

            Conta c1 = new Conta();
            c1.Numero = 123456;
            c1.Saldo = 2500.00;
            c1.Limite = 100.00;

            Console.WriteLine("\n" + c1.Numero);
            Console.WriteLine(c1.Saldo);
            Console.WriteLine(c1.Limite);

        }
    }
}
