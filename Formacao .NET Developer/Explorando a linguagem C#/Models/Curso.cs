using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__Metodos_e_Contrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() => Alunos.Count;

        public bool RemoverAluno(Pessoa aluno) => Alunos.Remove(aluno);

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso: {Nome}");
            for (int i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Alunos[i].NomeCompleto}.");
            }
        }
    }
}