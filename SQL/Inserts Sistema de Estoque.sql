												/*INSERTS SISTEMA DE GERENCIAMENTO*/
USE Estoque;

/*PARA LOGAR NO SISTEMA BASTA USAR QUALQUER CONTA DA TABELA Usuario 
LEMBRANDO QUE ALGUMAS NAO IRÃO LOGAR POIS NAO EXISTE SETOR DEFINIDO PARA ELAS,
SETORES QUE FUNCIONAM : ADMIN, ALMOXARIFE, COMPRAS E GERENCIA
TODAS AS SENHAS SAO = 12qw!@QW */

/*USUARIO E PERMISSÕES*/
INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Vitor', 'TI', 'ADMIN', 'Admin', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, ADMIN,CONTABILIDADE,ALMOXARIFADO,COMPRAS,COMERCIAL,COMEX,CUSTO,DIRETORIA,ENGENHARIA,MARKETING,FINANCEIRO,GERENCIA,PCP,PRODUÇÃO,QUALIDADE,RH,SEG_DO_TRABALHO,TI) VALUES 
((SELECT MAX(IdUsuario) FROM Usuario),'Admin', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Naiara', 'ALMOXARIFADO', 'ALMOXARIFADO', 'Naiara', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, ALMOXARIFADO) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Naiara', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Juni', 'COMPRAS', 'COMPRAS', 'Juni', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, COMPRAS) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Juni', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Cadena', 'CONTABILIDADE', 'CONTABILIDADE', 'Cadena', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, CONTABILIDADE) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Cadena', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Dubaldo', 'COMERCIAL', 'COMERCIAL', 'Dubaldo', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, COMERCIAL) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Dubaldo', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Ivo', 'COMEX', 'COMEX', 'Ivo', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, COMEX) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Ivo', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Eliza', 'CUSTO', 'CUSTO', 'Eliza', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, CUSTO) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Eliza', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Batman', 'DIRETORIA', 'DIRETORIA', 'Batman', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, DIRETORIA) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Batman', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Robin', 'ENGENHARIA', 'ENGENHARIA', 'Robin', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, ENGENHARIA) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Robin', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Coringa', 'MARKETING', 'MARKETING', 'Coringa', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, MARKETING) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Coringa', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Goku', 'FINANCEIRO', 'FINANCEIRO', 'Goku', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, FINANCEIRO) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Goku', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Kisame', 'GERENTE', 'GERENCIA', 'Kisame', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, GERENCIA) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Kisame', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Vegeta', 'PCP', 'PCP', 'Vegeta', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, PCP) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Vegeta', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Gohan', 'PRODUÇÃO', 'PRODUÇÃO', 'Gohan', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, PRODUÇÃO) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Gohan', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Naruto', 'QUALIDADE', 'QUALIDADE', 'Naruto', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, QUALIDADE) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Naruto', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Sasuke', 'R.H.', 'R.H.', 'Sasuke', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, RH) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Sasuke', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Itachi', 'SEG. DO TRABALHO', 'SEG. DO TRABALHO', 'Itachi', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, SEG_DO_TRABALHO) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Itachi', 'OK');

INSERT INTO Usuario (Nome, Funcao, Departamento, Usuario, Senha, DataCriacao) VALUES
('Sakura', 'T.I.', 'T.I.', 'Sakura', '8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda', GETDATE())

INSERT INTO Permissoes(IdUsuario, Usuario, TI) VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'Sakura', 'OK');

/*PRODUTO E ESTOQUE*/
INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('001','Teclado','59.90','UNIDADE','Eletronico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','1');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('002','Farinha','1.59','KG','Alimento');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','100');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('003','Cha','4.99','L','Alimento');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','110');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('004','Computador','3000.00','UNIDADE', 'Eletronico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','3');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('005','Maquiagem','2.50','UNIDADE','Cosmetico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','100');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('006','Batom','0.30','UNIDADE','Cosmetico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'1','100','55');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('007','Chuveiro','5.20','UNIDADE','Eletrico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','49');

INSERT INTO Produto (CodigoProduto,Nome,Preco,UnidadeMedida, Tipo) VALUES
('008','Geladeira','599.99','KG','Eletrodomestico');

INSERT INTO Estoque (IdProduto,QtdMinima,QtdMaxima,QtdEstoque) VALUES 
((SELECT MAX(IdProduto) FROM Produto),'3','100','51');

/*FORNECEDOR*/
INSERT INTO Fornecedor (Nome,CPF,CEP,Endereco,Bairro,Cidade,Complemento,Estado,Complemento2,Numero,Telefone,Telefone2,EMAIL) VALUES
('Chichi','','66985-852','Rua Teste','EOQ','Sao Paulo','Ters','SP','teste2','1233','+55(41)97856-2345','+55(41)12355-6665','chichi@gmail.com');

INSERT INTO Fornecedor (Nome,CPF,CEP,Endereco,Bairro,Cidade,Complemento,Estado,Complemento2,Numero,Telefone,Telefone2,EMAIL) VALUES
('Goten','333.666.545-17','83608-855','Rua Teste','EOQ','Campo Largo','teste','PR','teste2','9855','+55(41)99454-2345','+55(41)99223-6665','goten@gmail.com');

INSERT INTO Fornecedor (Nome,CPF,CEP,Endereco,Bairro,Cidade,Complemento,Estado,Complemento2,Numero,Telefone,Telefone2,EMAIL) VALUES
('Trunks','11,111,111/1111-11','55549-555','Rua Teste','EOQ','Matao','tets','MT','teste2','5672','+55(41)76843-2345','+55(41)51233-6665','trunks@gmail.com');


