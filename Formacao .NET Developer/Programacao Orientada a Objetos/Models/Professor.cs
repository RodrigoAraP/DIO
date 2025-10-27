using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Orientada_a_Objetos.Models
{
    internal class Professor : Pessoa
    {
        public Professor() { }

        public Professor(string nome) : base(nome) { }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, me chamo {Nome}, tenho {Idade} de idade e ganho R$ {Salario}.");
        }
    }
}
