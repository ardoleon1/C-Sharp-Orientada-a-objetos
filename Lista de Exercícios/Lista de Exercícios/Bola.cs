using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    public class Bola
    {
        public string cor;
        public double circunferencia;
        public string material;

        public Bola(string cor, double circunferencia, string material)
        {
            this.cor = cor;
            this.circunferencia = circunferencia;
            this.material = material;
        }

        public void AlterarCor(string color)
        {
            cor = color;
        }

        public void MostrarCor()
        {
            Console.WriteLine("Nova cor: " + cor);
        }
    }
}
