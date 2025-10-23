using Newtonsoft.Json;
using Propriedades__Metodos_e_Contrutores.Models;
using System.Globalization;

#region Propriedades

Pessoa p1 = new("Rodrigo", "Araujo");
Pessoa p2 = new(nome: "Ana Clara", sobrenome: "Souza");

Curso cursoDeIngles = new();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

#endregion

Console.WriteLine("");

#region Variaveis

string numero1 = "10";
string numero2 = "20";
string resultado = numero1 + numero2;

Console.WriteLine(resultado);

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario.ToString("C4")}");

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 141025;
Console.WriteLine(numero.ToString("##/##/##"));

string dataString = "2025-77-24 12:20";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-M-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if (sucesso)
{
    Console.WriteLine(data.ToString("dd/MM/yy HH:mm:ss"));
}
else
{
    Console.WriteLine($"Data invalida: [{dataString}]");
}

#endregion

Console.WriteLine("");

#region Excecoes

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeituraa.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo nao encontrado. \n{ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretorio nao encontrado. \n{ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Excecao generica. \n{ex.Message}");
}
finally
{
    Console.WriteLine("Fim!");
}

Console.WriteLine("");

new ExemploExececao().Metodo1();

#endregion

Console.WriteLine("");

#region Colecoes

#region Fila

Queue<int> fila = new();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
foreach (int item in fila)
{
    Console.WriteLine(item);
}


Console.WriteLine($"Elemento removido: {fila.Dequeue()}\n");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

#endregion

Console.WriteLine("");

#region Pilha

Stack<int> pilha = new();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Elemento removido: {pilha.Pop()}\n");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

#endregion

Console.WriteLine("");

#region Dictionary

//         <unique, any>
Dictionary<string, string> estados = new();

estados.Add("SP", "Sao Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("");

estados.Remove("BA");
estados["SP"] = "São Paulo";
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("");

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente");
}
else
{
    Console.WriteLine("Valor nao existente");
}

Console.WriteLine("");

Console.WriteLine(estados["MG"]);

#endregion

#endregion

Console.WriteLine("");

#region Tuplas

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rodrigo", "Araujo", 1.70M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Rosimeire", "Araujo", 1.60M);
var outroExemploTuplaCreate = Tuple.Create(3, "Leonardo", "Araujo", 170M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

Console.WriteLine("");

LeituraArquivo arquivo = new();
var (certo, linhasArquivo, _) = arquivo.lerArquivo("Arquivos/arquivoLeitura.txt");

if (certo)
{
    // Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Nao foi possivel ler o arquivo");
}

#endregion

Console.WriteLine("");

#region Descontrutor e IF Ternario

Pessoa p3 = new("Leonardo", "Araujo");
(string nome, string sobrenome) = p3;
Console.WriteLine($"{nome} {sobrenome}");

Console.WriteLine("");

int num = 10;

if (num % 2 == 0)
{
    Console.WriteLine($"{num} - PAR");
}
else
{
    Console.WriteLine($"{num} - IMPAR");
}

bool par = num % 2 == 0;
Console.WriteLine($"{num} - {(par ? "PAR" : "IMPAR")}");

#endregion

Console.WriteLine("");

#region Serializacao

DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new();

Vendas v1 = new(1, "Material de escritorio", 25.00M, dataAtual);
Vendas v2 = new(2, "Licenca de Software", 110.00M, dataAtual);
v2.Desconto = 10;

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

#endregion

Console.WriteLine("");

#region Deserializacao

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (Vendas venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
        $"{(venda.Desconto.HasValue ? $", Desconto: {venda.Desconto}" : "")}.");
}

#endregion

Console.WriteLine("");

#region Tipos Especiais

#region Null
bool? receberEmail = null;

if (receberEmail != null && receberEmail.Value)
{
    Console.WriteLine("Envio de e-mail autorizado.");
}
else
{
    Console.WriteLine("Envio de e-mail nao autorizado.");
}

#endregion

Console.WriteLine("");

#region Anonimo

var tipoAnonimo = new { Nome = "Rodrigo", Sobrenome = "Araujo", Altura = 1.70 };

Console.WriteLine($"Nome: {tipoAnonimo.Nome} {tipoAnonimo.Sobrenome}, Altura: {tipoAnonimo.Altura}");

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto} - R$ {venda.Preco}");
}

#endregion

Console.WriteLine("");

#region Dinamico

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");


#endregion

Console.WriteLine("");

#region Classe generica

MeuArray<int> arrayInteiro = new();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);

#endregion

Console.WriteLine("");

#region Metodo de extensao

numero = 23;
par = false;

par = numero.EhPar();

Console.WriteLine($"O numero {numero} e {(par ? "par" : "impar")}");

#endregion

#endregion

Console.WriteLine("");

#region Stack Heap e Garbade Collector

int a = 10;
int b = a;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

Console.WriteLine("");

Pessoa pessoa1 = new(nome: "Rodrigo", sobrenome: "Araujo");
Pessoa pessoa2 = pessoa1;

Console.WriteLine($"Nome da primeira pessoa: {pessoa1.NomeCompleto}");
Console.WriteLine($"Nome da segunda pessoa: {pessoa2.NomeCompleto}");

pessoa2.Nome = "Leonardo";

Console.WriteLine($"Nome da primeira pessoa: {pessoa1.NomeCompleto}");
Console.WriteLine($"Nome da segunda pessoa: {pessoa2.NomeCompleto}");

#endregion