using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            ani.Nome = "Rex";
            Console.WriteLine(ani);
            ani.Acordar();
            ani.Comer();
            ani.Dormir();
            Console.WriteLine("\n----------------------");
            Mamifero mam = new Mamifero();
            mam.Nome = "Thor";
            mam.idade = 05;
            Console.WriteLine(mam);
            mam.Acordar();
            mam.Mamar();
            mam.Comer();
            mam.Dormir();

            Console.ReadKey();
        }
    }
}
