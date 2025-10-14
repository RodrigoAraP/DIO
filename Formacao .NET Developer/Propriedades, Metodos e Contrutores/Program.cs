using Propriedades__Metodos_e_Contrutores.Models;

Pessoa p1 = new("Rodrigo", "Araujo");
Pessoa p2 = new(nome: "Ana Clara", sobrenome: "Souza");

Curso cursoDeIngles = new();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
