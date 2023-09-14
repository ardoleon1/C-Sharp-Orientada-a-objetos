using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    public class Retangulo
    {
        private double altura;
        private double largura;
        private double area;

        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("Valor inválido...");
                }
            }
        }
        public double Largura
        {
            get
            {
                return largura;
            }
            set
            {
                if (value > 0)
                {
                    Largura = value;
                }
                else
                {
                    Console.WriteLine("Valor inválido...");
                }
            }
        }
        public double Area { get { return area; } }

        public Retangulo(double Altura, double Largura)
        {
            this.Altura = Altura;
            this.Largura = Largura;
            CalcularArea();
        }

        private void CalcularArea()
        {
            area = Altura * Largura;
        }
    }
}
