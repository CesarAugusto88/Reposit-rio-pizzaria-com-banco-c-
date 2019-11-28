-- Criou-se o banco Banco_Pizzaria
CREATE DATABASE Banco_Pizzaria
GO
-- Habilita o Contexto
USE Banco_Pizzaria;
GO

-- Apaga Tabela
DROP table Funcionario;
GO

-- Cria Tabela Cliente
CREATE TABLE Cliente  
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  
 Nome varchar (80),  
 Cpf varchar(15),
 Rg varchar(15),
 Celular varchar(15),  
 Genero varchar(15),
 Email varchar(70),
 Logradouro varchar(100),
 Numero int,
 Complemento varchar(15),
 Bairro varchar(50),
);  

-- Cria Tabela Funcionario PkId para tabela LoginSenha
CREATE TABLE Funcionario 
(  
 Id int NOT NULL IDENTITY(1,1),  
 Nome varchar (80),  
 Cpf varchar(15),
 Rg varchar(15),
 Celular varchar(15),  
 Genero varchar(15),
 Email varchar(70),
 Logradouro varchar(100),
 Numero int,
 Complemento varchar(15),
 Bairro varchar(50),
 EmailLogin varchar(70), 
 Senha varchar(20)

);

-- Tentar fazer uma verificação para o login entre as duas tabelas.
-- Criado Tabela LoginSenha. Não utilizado
CREATE TABLE LoginSenha
(  
 Id int NOT NULL IDENTITY(1,1),
 Email varchar(70), 
 Senha varchar(20),

); 



select * from Funcionario go


--select * from LoginSenha go

-- Cria Tabela Pizza
CREATE TABLE Pizza  
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  
 Nome varchar (80),  
 Ingrediente1 varchar(80),
 Ingrediente2 varchar(80),
 Ingrediente3 varchar(80),
 Ingrediente4 varchar(80),
 Valor decimal(10,2),
 );

 -- Criando Tabela Pedido...
CREATE TABLE Pedido 
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  

 );

-- nao tem mais
-- INSERT INTO Endereco VALUES ('Rua Francisco Candido Ribeiro', 96, 'AP-2', 'Vila Inglesa');  


-- SELECT * FROM Endereco;
SELECT * FROM Cliente;
SELECT * FROM Funcionario;
SELECT * FROM Pizza;
SELECT * FROM LoginSenha;

-- SELECT MAX(Id) from Endereco;

select * from Cliente where Id = 11;

-- deletar linha da tabela
SELECT * FROM LoginSenha
WHERE (Id = 1 or Id= 2 or Id = 3);

-- Exibe o nome das tabelas que existem no banco de dados em uso
SELECT name 
FROM sys.tables
GO


CREATE PROCEDURE busca_Cliente
	@nome VARCHAR(50)
AS
	SET NOCOUNT ON
	SELECT Nome  AS 'Nome do Cliente'
		   
		   
		   FROM Cliente 
			  
			  WHERE Nome LIKE @nome + '%'
			  ORDER BY Nome
			  SET NOCOUNT OFF
GO

-- Utiliza a stored procedure SP_BUSCADADOSALUNOS
EXEC busca_Cliente'a'
GO

drop procedure busca_ClienteInicial