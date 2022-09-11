CREATE TABLE Herois(Id INT IDENTITY, 
					Nome VARCHAR(100) NOT NULL,
					Escuridao BIT,
					NomePessoa VARCHAR(150) NOT NULL,
					Raca VARCHAR(200) NOT NULL,
					ContaBancaria DECIMAL(17,2) NOT NULL,
					DataNascimento DATE,
					Sexo CHAR(1),
					QtdFilmes TINYINT,
					Descricao TEXT);

SELECT * FROM Herois;