using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_do_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente adam = new Gerente("Carlinhos", 15000, "adam@gmail.com", "admin123");
            Console.WriteLine(adam);
            //double bonifica = adam.CalcularBonificao();
            //Console.WriteLine($"Bonificação: {bonifica:c2}");
            Console.WriteLine($"Bonificação: {adam.CalcularBonificao():c2}");

            Telefonista tel = new Telefonista("Sandro Oliveira", 2500, 28);
            Console.WriteLine("\n"+ tel);
            Console.WriteLine($"Bonificação: {tel.CalcularBonificao():c2}");

            Secretaria sec = new Secretaria("Sabrina Silva", 3000, 13);
            Console.WriteLine("\n" + sec);
            Console.WriteLine($"Bonificação: {sec.CalcularBonificao():c2}");

            Console.ReadKey();
        }
    }
}
