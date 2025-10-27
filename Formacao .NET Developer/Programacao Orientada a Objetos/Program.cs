using Programacao_Orientada_a_Objetos.Interfaces;
using Programacao_Orientada_a_Objetos.Models;

#region Abstracao

Pessoa p1 = new("Rodrigo");
p1.Idade = 22;

p1.Apresentar();

#endregion

Console.WriteLine("");

#region Encapsulamento

ContaCorrente c1 = new(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

#endregion

Console.WriteLine("");

#region Heranca e Polimorfismo

Aluno a1 = new("Rodrigo");
a1.Idade = 22;
a1.Email = "araujo.rodrigo.passos@gmail.com";
a1.Nota = 10;
a1.Apresentar();

Professor prof1 = new("Leonardo");
prof1.Idade = 27;
prof1.Salario = 10000;
prof1.Apresentar();

#endregion

Console.WriteLine("");

#region Abstrata

Corrente c = new();
c.Creditar(500);
c.ExibirSaldo();

#endregion

Console.WriteLine("");

#region Classe Object

Computador pc = new();
Console.WriteLine(pc.ToString());

#endregion

Console.WriteLine("");

#region Interface

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));

#endregion