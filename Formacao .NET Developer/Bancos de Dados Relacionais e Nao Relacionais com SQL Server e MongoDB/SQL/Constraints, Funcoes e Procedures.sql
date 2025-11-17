SELECT * FROM Produtos

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero)
VALUES ('Racing Socks, S', 8.99, 'P', 'U')

ALTER TABLE Produtos ADD UNIQUE (Nome)

ALTER TABLE Produtos 
ADD CONSTRAINT CHK_ColunaGenero CHECK (Genero = 'U' OR Genero = 'M' OR Genero = 'F')

ALTER TABLE Produtos 
ADD DEFAULT GETDATE() FOR DataCadastro

INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Nomes', 'Cor', 0, 'G', 'G', GETDATE())

ALTER TABLE Produtos DROP CONSTRAINT UQ__Produtos__7D8FE3B230E58719

CREATE PROCEDURE InserirNovoProduto 
@Nome varchar(255), @Cor varchar(50), @Preco decimal, @Tamanho varchar(5), @Genero char(1)
AS
INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)

EXEC InserirNovoProduto 
'Novo Produto Procedure', 'Coloriddo', 50, 'G', 'U'

CREATE PROCEDURE ObterProdutosPorTamanho
@Tamanho VARCHAR(5)
AS
SELECT * FROM Produtos WHERE Tamanho = @Tamanho

SELECT * FROM Produtos WHERE Tamanho = 'M'
EXEC ObterProdutosPorTamanho 'GG'

CREATE PROCEDURE ObterTodosProdutos
AS
SELECT * FROM Produtos

EXEC ObterTodosProdutos

CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)
BEGIN RETURN @Preco - @Preco / 100 * @Porcentagem
END

SELECT Nome, Preco, FORMAT(Preco - Preco / 100 * 10, 'N2')AS PrecoComDesconto
FROM Produtos
WHERE Tamanho = 'M'

SELECT Nome, Preco, dbo.CalcularDesconto (Preco, 50) AS PrecoComDesconto
FROM Produtos
WHERE Tamanho = 'M'