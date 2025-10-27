using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Orientada_a_Objetos.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno() { }
        public Aluno(string nome) : base(nome) { }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, me chamo {Nome}, tenho {Idade} anos e minha nota foi {Nota}.");
        }
    }
}
