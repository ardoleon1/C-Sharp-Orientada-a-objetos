using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Lado = 2;
            Console.WriteLine("Área do quadrado: {0}", quadrado.calcularArea());

            Retangulo retangulo = new Retangulo();
            retangulo.Largura = 2;
            retangulo.Comprimento = 2;
            Console.WriteLine("Área do retângulo: {0}", retangulo.calcularArea());

            Circulo circulo = new Circulo();
            circulo.Raio = 2;
            Console.WriteLine("Área do círculo: {0}", circulo.calcularArea());

            Console.ReadKey();
        }
    }
}
