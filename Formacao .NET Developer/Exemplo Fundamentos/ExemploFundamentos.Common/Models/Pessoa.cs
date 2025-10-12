using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Fundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa com nome e idade, e permite apresentar essas informações.
    /// </summary>

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Retorna uma saudação com o nome e a idade da pessoa.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
            // Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos.");
        }
    }
}