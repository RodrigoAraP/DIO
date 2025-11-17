SELECT Nome, Sobrenome, Email, AceitaComunicados 
FROM Clientes
WHERE Nome LIKE '%G%'
ORDER BY Nome, Sobrenome

INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Rodrigo', 'Araujo', 'araujo.rodrigo.passos@gmail.com', 1, GETDATE())

INSERT INTO Clientes VALUES ('Ana Clara', 'Souza', 'ana.souza@gmail.com', 1, GETDATE())

SELECT *
FROM Clientes
WHERE Nome = 'Rodrigo'
	OR Nome = 'Ana Clara'

UPDATE Clientes
SET Email = 'rodrigo.araujo@gmail.com',
	AceitaComunicados = 0
WHERE Id = 1001

BEGIN TRAN
ROLLBACK

DELETE Clientes
WHERE Id = 1003