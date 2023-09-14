using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício Calcular Área---");
            double altura = 0;
            double largura = 0;
            bool continuar = true;

            while (continuar)
            {
                do
                {
                    Console.Write("Informe a altura: ");
                    altura = double.Parse(Console.ReadLine());
                } while (altura <= 0);

                do
                {
                    Console.Write("Informe a largura: ");
                    largura = double.Parse(Console.ReadLine());
                } while (largura <= 0);
                Retangulo ret = new Retangulo(altura, largura);

                Console.Clear();

                Console.WriteLine($"Largura: {ret.Largura}" +
                    $"\nAltura: {ret.Altura}" +
                    $"\nÁrea: {ret.Area}");
                Console.ReadKey();
            }
        }
    }
}
