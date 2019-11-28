-- Criou-se o banco Projeto_Pizzaria
CREATE DATABASE Projeto_Pizzaria
GO
-- Habilita o Contexto
USE Projeto_Pizzaria;
GO

-- Apaga Tabela
DROP table LoginSenha;
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

-- Cria Tabela Funcionario
CREATE TABLE Funcionario  
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

-- Criado Tabela LoginSenha. PkId para abrir e fechar caixa
CREATE TABLE LoginSenha
(  
 Id int NOT NULL IDENTITY(1,1),
 Email varchar(70), 
 Senha varchar(20),
 CONSTRAINT PkIdLoginSenha PRIMARY KEY NONCLUSTERED (Id)

); 

select * from LoginSenha go
select * from Funcionario go


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


-- Cria Tabela AbrirCaixa
CREATE TABLE AbrirCaixa
(  
	FkIdLoginSenha    int,
	ValorInicial    decimal(10,2),	
    FOREIGN KEY(FkIdLoginSenha) REFERENCES LoginSenha(Id) 
); 


-- Cria Tabela FecharCaixa
CREATE TABLE FecharCaixa
(  
	FkIdLoginSenha    int,
	ValorFinal       decimal(10,2),
    FOREIGN KEY(FkIdLoginSenha) REFERENCES LoginSenha(Id)

); 


-- Criar Tabela Pedido...
CREATE TABLE Pedido 
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  

 );


-- SELECT * FROM Endereco;
SELECT * FROM Cliente;
SELECT * FROM Funcionario;
SELECT * FROM Pizza;
SELECT * FROM LoginSenha;
SELECT * FROM AbrirCaixa;
SELECT * FROM FecharCaixa;

INSERT INTO LoginSenha VALUES ('marques.sousa@ifsp.edu.br', '123');
INSERT INTO LoginSenha VALUES ('adm@adm', '123');


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

-- FAZER BUSCA NA TABELA CLIENTES APARECENDO TODOS COM A PRIMEIRA LETRA
-- UTILIZANDO LIKE

-- Exemplo Chaves
CREATE TABLE Endereco
(
  Id int NOT NULL IDENTITY(1,1),
  Logradouro varchar(100),
  Numero int,
  Complemento varchar(15),
  Bairro varchar(50),
  Cep varchar(10),
  Cidade varchar(70),
  Estado varchar(30),
  Pais varchar(70),
  CONSTRAINT PkIdEndereco PRIMARY KEY NONCLUSTERED (Id)
)

CREATE TABLE Cliente  
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  
 Nome varchar (80),  
 Cpf varchar(15),
 Rg varchar(15),
 TipoSanguineo varchar(15),
 Celular varchar(15),  
 Genero varchar(15),
 Email varchar(70),
 FkIdEndereco int,
 FOREIGN KEY(FkIdEndereco) REFERENCES Endereco(Id)  
); 