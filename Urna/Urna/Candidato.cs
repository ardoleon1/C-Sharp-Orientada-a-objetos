using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    internal class Candidato
    {
        //Atributos
        private int numero;
        private string nome;
        private int votos;

        //Métodos de acessos (propriedades)
        public int Numero { get; set; }
        public string Nome { get; set; }
        public int Votos { get { return votos; } }

        public Candidato(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            votos = 0;
        }

        public void DepositarVoto()
        {
            votos++;
        }
        public void ApurarResultado()
        {
            Console.WriteLine("$\nNúmero: {Numero}\nNome: {Nome}\nVotos: {Votos}");
        }
    }
}
