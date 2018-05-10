												/*SISTEMA DE GERENCIAMENTO*/
/*CRIACAO DO BANCO DE DADOS E USO DELE*/
CREATE DATABASE Estoque;
Use Estoque;

/*SELECTS*/
SELECT * FROM Usuario;
SELECT * FROM Fornecedor;
SELECT * FROM Estoque;
SELECT * FROM Produto;
SELECT * FROM PedidoItem;
SELECT * FROM Pedido;
SELECT * FROM Permissoes;
SELECT * FROM Orcamento;

/*DROP TABLES*/
DROP TABLE Permissoes;
DROP TABLE Fornecedor;
DROP TABLE Estoque;
DROP TABLE Produto;
DROP TABLE PedidoItem;
DROP TABLE Usuario;
DROP TABLE Orcamento;
DROP TABLE Pedido;

/*DELETE FROM TABLES*/
DELETE FROM Permissoes;
DELETE FROM Usuario;
DELETE FROM Fornecedor;
DELETE FROM Estoque;
DELETE FROM PedidoItem;
DELETE FROM Produto;
DELETE FROM Pedido;
DELETE FROM Orcamento;

/*CREATE TABLES*/
CREATE TABLE Usuario
(
	  IdUsuario INTEGER IDENTITY(1,1) PRIMARY KEY
	, Nome VARCHAR(100)
	, Funcao VARCHAR (20)
	, Departamento VARCHAR (25)
	, Usuario VARCHAR (30)
	, Senha VARCHAR (100) 
	, DataCriacao DATETIME
);

CREATE TABLE Permissoes
(
	  IdPermissoes INTEGER IDENTITY(1,1) PRIMARY KEY
	, IdUsuario INTEGER
	, Usuario VARCHAR(100)
	, ADMIN CHAR(2) 
	, ALMOXARIFADO CHAR(2)
	, COMPRAS CHAR(2)
    , CONTABILIDADE CHAR(2)
	, COMERCIAL CHAR(2)
	, COMEX CHAR(2)
	, CUSTO CHAR(2)
	, DIRETORIA CHAR(2)
	, ENGENHARIA CHAR(2)
	, MARKETING CHAR(2)
	, FINANCEIRO CHAR(2)
	, GERENCIA CHAR(2)
	, PCP CHAR(2)
	, PRODUÇÃO CHAR(2)
	, QUALIDADE CHAR(2)
	, RH  CHAR(2)
	, SEG_DO_TRABALHO CHAR(2)
	, TI CHAR(2)
	, FOREIGN KEY(IdUsuario) REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Produto
(
	   IdProduto INTEGER IDENTITY (1,1) PRIMARY KEY
	 , CodigoProduto VARCHAR(10)
	 , Nome VARCHAR (50)
	 , Preco FLOAT
	 , UnidadeMedida VARCHAR(20)
	 , Tipo VARCHAR(50)
);

CREATE TABLE Pedido
(
	  IdPedido INTEGER IDENTITY(1,1) PRIMARY KEY
	, Solicitante VARCHAR(50)
	, Urgencia VARCHAR (20)
	, Motivo VARCHAR (1000)
	, DataCriacao DATETIME
	, Status VARCHAR(15)
	, Tipo VARCHAR (30)
	, Valor FLOAT
);

CREATE TABLE PedidoItem
(
	  IdPedidoItem INTEGER IDENTITY(1,1) PRIMARY KEY
	, IdPedido INTEGER
	, Cod VARCHAR(100)
	, Nome VARCHAR (20)
	, QtdEstoque FLOAT
	, QtdMinima FLOAT
	, QtdMaxima FLOAT
    , UnidadeMedida VARCHAR(20)
	, Solicitar FLOAT
	, FOREIGN KEY (IdPedido) REFERENCES Pedido(IdPedido)
);

CREATE TABLE Fornecedor
(
	  IdFornecedor INTEGER IDENTITY (1,1) PRIMARY KEY
	, Nome VARCHAR(100)
	, CPF VARCHAR(20)
	, CEP VARCHAR(9)
	, Endereco VARCHAR(100)
	, Bairro VARCHAR(30)
	, Cidade VARCHAR(30)
	, Complemento VARCHAR(1000)
	, Estado VARCHAR(20)
	, Complemento2 VARCHAR(1000)
	, Numero VARCHAR(30)
	, Telefone VARCHAR(30)
	, Telefone2 VARCHAR (30)
	, EMAIL VARCHAR (50)
);

CREATE TABLE Estoque
(
	  IdEstoque INTEGER IDENTITY (1,1) PRIMARY KEY
	, IdProduto INTEGER
	, QtdMinima FLOAT
	, QtdMaxima FLOAT
	, QtdEstoque FLOAT
	, FOREIGN KEY (IdProduto) REFERENCES Produto(IdProduto)
);

CREATE TABLE Orcamento
(
	  IdOrcamento INTEGER IDENTITY(1,1) PRIMARY KEY
	, IdPedido INTEGER
	, Tipo VARCHAR (20)
	, DataEmissao DATETIME
	, Observacoes VARCHAR (1000)
	, Vendedor VARCHAR (100)
	, PrazoEntrega VARCHAR(15)
	, CondicaoPag VARCHAR(30)
	, ValorAdicional FLOAT
	, Valor FLOAT
	, ValorSoma FLOAT
	, QtdItens INTEGER
	, FOREIGN KEY (IdPedido) REFERENCES Pedido(IdPedido)
);


	
/*COMANDOS PARA RESETAR O IDENTITY (AUTO_INCRIMENT) DEPOIS DE JA TER INSERIDO ALGUM DADO E APAGADO*/
DBCC CheckIdent ('Usuario',RESEED, 0);
DBCC CheckIdent ('Permissoes',RESEED, 0);
DBCC CheckIdent ('Produto',RESEED, 0);
DBCC CheckIdent ('Fornecedor',RESEED, 0);
DBCC CheckIdent ('Estoque',RESEED, 0);
DBCC CheckIdent ('Pedido',RESEED, 1);
DBCC CheckIdent ('PedidoItem',RESEED, 1);
DBCC CheckIdent ('Orcamento',RESEED, 1);
