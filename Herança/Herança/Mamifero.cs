using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public class Mamifero : Animal //Herança
    {
        public int idade;
        public void Mamar()
        {
            Console.WriteLine("Mamiferos mamam...");
        }
        public override string ToString()
        {
            return base.ToString() + "\nIdade: " + idade;
        }
    }
}
