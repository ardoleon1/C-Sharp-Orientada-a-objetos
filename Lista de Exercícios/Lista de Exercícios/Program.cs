using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Resolução dos Exercícios---");

            Console.WriteLine("\n---Bola---");
            Bola bola = new Bola("Amarelo", 10.00, "Lisa");
            Console.Write("Digite uma cor: ");
            string cor = Console.ReadLine();
            bola.AlterarCor(cor);
            bola.MostrarCor();

            Console.WriteLine("\n---Quadrado---");
            Quadrado quadrado = new Quadrado(10);
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());
            quadrado.MudarValorLado(valor);
            Console.WriteLine("Perímetro: " + quadrado.CalcularPerimetro());
            Console.WriteLine("Área: " + quadrado.CalcularArea());

            Console.WriteLine("\n---Retangulo---");
            Retangulo retangulo = new Retangulo(0.0, 0.0);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
