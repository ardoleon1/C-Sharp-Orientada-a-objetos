using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;

        public Pessoa (string nome, int idade, double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }
        public void Envelhecer()
        {
            idade++;
            if (idade <= 20)
            {
                altura = altura + 0.5;
            }
        }
        public void Engordar(double valor)
        {
            peso = peso + valor;
        }
        public void Emagrecer(double valor)
        {
            peso = peso - valor;
        }
        public void Crescer(double valor)
        {
            altura = altura + valor;
        }
    }
}
