using Exemplo_Fundamentos.Common.Models;

double pi, raio, volume;
pi = 3.14159;
//TODO: Complete os espaços em branco com uma possível solução para o desafio     
raio = 1523.0;
volume = pi * (4 / 3.0) * Math.Pow(raio, 3);
double arredondado = Math.Round(volume, 3);

Console.WriteLine(arredondado);

// Instanciação da classe Pessoa - Antes do C# 9.0
Pessoa pessoa1 = new();

// Atribuição de valores aos atributos da classe Pessoa
pessoa1.Nome = "Rodrigo";
pessoa1.Idade = 22;

// Chamada do método Apresentar da classe Pessoa
pessoa1.Apresentar();

int[] arrayInteriros = new int[4];

/*
 * Linha 1
 * Linha 2
 * Linha 3
 */

arrayInteriros[0] = 72;
arrayInteriros[1] = 64;
arrayInteriros[2] = 50;
arrayInteriros[3] = 1;

for (int i = 0; i < arrayInteriros.Length; i++)
{
    Console.WriteLine($"Posição N° {i} - Valor: {arrayInteriros[i]}");
}

int contador = 0;
foreach (int valor in arrayInteriros)
{
    Console.WriteLine($"Posição N° {contador} - Valor: {valor}");
    contador++;
}

Array.Resize(ref arrayInteriros, arrayInteriros.Length * 2);

int[] arrayInteiroDobrado = new int[arrayInteriros.Length * 2];
Array.Copy(arrayInteriros, arrayInteiroDobrado, arrayInteriros.Length);

Console.WriteLine("\n");

List<string> ListaString = new List<string>();

ListaString.Add("SP");
ListaString.Add("BA");
ListaString.Add("MG");
ListaString.Add("SC");

for (int i = 0; i < ListaString.Count; i++)
{
    Console.WriteLine($"Posição N° {i} - Valor: {ListaString[i]}");
}

contador = 0;
foreach (string item in ListaString)
{
    Console.WriteLine($"Posição N° {contador} - Valor: {item}");
    contador++;

}

Console.WriteLine($"Itens na lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");

ListaString.Add("RJ");

Console.WriteLine($"Itens na lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");

ListaString.Remove("SP");

Console.WriteLine($"Itens na lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");

Calculadora c = new();
c.Somar(10, 20);
c.Subtrair(20, 10);   

//Antes de realizar a fatoracao
//namespace Exemplo_Fundamentos.Common.Models;

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Rodrigo";
//pessoa1.Idade = 22;
//pessoa1.Apresentar();

//// Tipos de dados
//Console.WriteLine("\n");
//string apresentacao = "Ola, seja bem vindo";
//int quantidade = 1;
//quantidade = 10;
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine($"Quantidade: {quantidade}");
//Console.WriteLine($"Altura: {altura.ToString("0.00")}");
//Console.WriteLine($"Preco: R$ {preco}");
//Console.WriteLine($"Condicao: {condicao}");

//// DateTime
//Console.WriteLine("\n");
//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//// TimeSpan
//Console.WriteLine("\n");
//int a = 10;
//int b = 20;

//int c = a + b;

//c = c + 5;
//c += 5;
//c -= 5;
//c *= 5;
//Console.WriteLine(c);

//// Cast - Casting
//Console.WriteLine("\n");
//a = Convert.ToInt32("5");
//a = int.Parse("10");
//Console.WriteLine(a);

//// Cast - Casting (type casting)
//Console.WriteLine("\n");
//a = int.MaxValue;
//double z = a;
//a = (int)z;

//Console.WriteLine(z);
//Console.WriteLine(a);

//// Operadores aritméticos
//Console.WriteLine("\n");
//z = (2 + 4) / 2;
//Console.WriteLine(z);

//// TryParse
//Console.WriteLine("\n");
//string y = "15-";
//int.TryParse(y, out a);

//Console.WriteLine(a);

//// Operadores condicionais
//Console.WriteLine("\n");
//int quantidadeDisponivel = 13;
//int quantidadeComprada = 0;
//bool vendaAprovada = quantidadeComprada <= quantidadeDisponivel && quantidadeComprada > 0;

//Console.WriteLine("Quantidade disponivel: " + quantidadeDisponivel);
//Console.WriteLine("Quantidade comprada: " + quantidadeComprada);
//Console.WriteLine($"É possivel realizar a compra? {vendaAprovada}");
//Console.WriteLine("\n");

//if (quantidadeComprada == 0)
//{
//    Console.WriteLine("Venda nao pode ser realizada, pois nao ha itens no carrinho.");
//}
//else if (vendaAprovada)
//{
//    Console.WriteLine("Compra realizada com sucesso.");
//}
//else
//{
//    Console.WriteLine("Desculpe, nao temos a quantidade desejada em estoque.");
//}

//Console.WriteLine("\n");
//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine().ToUpper();

//if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
//{
//    Console.WriteLine($"A letra {letra} digitada é uma vogal.");
//}
//else
//{
//    Console.WriteLine($"A letra {letra} digitada nao é uma vogal.");
//}

//Console.WriteLine("\n");
//// Switch case
//Console.WriteLine("Digite uma letra");
//letra = Console.ReadLine().ToUpper();

//switch (letra)
//{
//    case "A":
//    case "E":
//    case "I":
//    case "O":
//    case "U":
//        Console.WriteLine($"A letra {letra} digitada é uma vogal.");
//        break;
//    default:
//        Console.WriteLine($"A letra {letra} digitada nao é uma vogal.");
//        break;
//}

//// Operadores lógicos
//Console.WriteLine("\n");
//// OR - ||
//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//{
//    Console.WriteLine("Entrada liberada.");
//}
//else
//{
//    Console.WriteLine("Entrada nao liberada.");
//}

//Console.WriteLine("\n");
//// AND - &&
//bool possuiPresencaMinima = true;
//double nota = 6;

//if (possuiPresencaMinima && nota >= 7)
//{
//    Console.WriteLine("Aprovado.");
//}
//else
//{
//    Console.WriteLine("Reprovado.");
//}

//Console.WriteLine("\n");
//// NOT - !
//bool choveu = false;
//bool estaTarde = false;
//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar.");
//}
//else
//{
//    Console.WriteLine("Nao vou pedalar.");
//}

//Console.WriteLine("\n");

//Calculadora calc = new Calculadora();
//calc.Somar(25, 10);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Cosseno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);

//Console.WriteLine("\n");

//int numero = 10;

//Console.WriteLine($"Numero: {numero}");
//Console.WriteLine($"Incrementado: {++numero}");
//Console.WriteLine($"Decrementado: {--numero}");

//Console.WriteLine("\n");
//// Estruturas de repetição
//// For
//numero = 5;
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} * {i} = {numero * i}");
//}

//Console.WriteLine("\n");
//// While
//int contador = 1;
//while (contador <= 10)
//{
//    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
//    contador++;

//    if (contador == 6) { break; }
//}

//Console.WriteLine("\n");
//// Do While
//int soma = numero = 0;
//Console.WriteLine(soma + numero);
//do
//{
//    Console.WriteLine("Digite um numero (0 = Sair) ");
//    numero = Convert.ToInt32(Console.ReadLine());
//    soma += numero;
//} while (numero != 0);
//Console.WriteLine($"Soma: {soma}");

//string opcao;
//bool sair = true;

//while (!sair)
//{
//    Console.Clear();
//    Console.WriteLine("Digite a sua opcao:");
//    Console.WriteLine("1 - Cadastrar Cliente");
//    Console.WriteLine("2 - Buscar Cliente");
//    Console.WriteLine("3 - Apagar Cliente");
//    Console.WriteLine("4 - Sair");

//    opcao = Console.ReadLine();

//    switch (opcao)
//    {
//        case "1":
//            Console.WriteLine("Cadastro de Cliente");
//            break;
//        case "2":
//            Console.WriteLine("Busca de Cliente");
//            break;
//        case "3":
//            Console.WriteLine("Apagar Cliente");
//            break;
//        case "4":
//            Console.WriteLine("Saindo...");
//            sair = true;
//            break;
//        default:
//            Console.WriteLine("Opcao invalida");
//            break;
//    }
//}