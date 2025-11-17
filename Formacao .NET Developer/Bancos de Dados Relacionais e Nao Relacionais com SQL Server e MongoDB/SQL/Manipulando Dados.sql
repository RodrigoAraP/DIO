SELECT * FROM Produtos

SELECT COUNT(*) QuantiddadeProdutos 
FROM Produtos

SELECT COUNT(*) QuantidadeTamanhoM 
FROM Produtos 
WHERE Tamanho = 'M' 

SELECT SUM(Preco) PrecoTotalTamanhoM
FROM Produtos 
WHERE Tamanho = 'M' 

SELECT MAX(Preco) ProdutoMaisCaro, MIN(Preco)ProdutoMaisBarato, AVG(Preco) MediaDePreco
FROM Produtos 

SELECT Nome + ' - ' + Cor + ' - ' + Genero NomeProduto
FROM Produtos

SELECT UPPER(Nome) Nome, LOWER(Cor) Cor
FROM Produtos

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

UPDATE Produtos 
SET DataCadastro = GETDATE()

ALTER TABLE Produtos
DROP COLUMN DataCadastro

SELECT FORMAT(DataCadastro, 'dd/MM/yyyy hh:mm:ss') as Data
FROM Produtos

SELECT Tamanho, COUNT(*) Quantidade  
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC

CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes 
	FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)

INSERT INTO Enderecos 
VALUES (1001, 'Rua Abdenago Lisboa', 'Heliopolis', 'Belo Horizonte', 'MG')

SELECT * FROM Clientes WHERE Id = 1001
SELECT * FROM Enderecos WHERE IdCliente = 1001

SELECT c.Nome, c.Sobrenome, c.Email, e.Rua, e.Bairro, e.Cidade, e.Estado
FROM Clientes c
	INNER JOIN Enderecos e ON c.Id = e.IdCliente
WHERE c.Id = 1001