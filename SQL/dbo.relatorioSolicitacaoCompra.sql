USE [Estoque]
GO
/****** Object:  StoredProcedure [dbo].[relatorioSolicitacaoCompra]    Script Date: 23/04/2018 14:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[relatorioSolicitacaoCompra] 
(
	@IDPEDIDO INT
)
AS
BEGIN
SELECT p.Cod as Cod_Produto
	, p.Nome as Nome_Produto
	, Solicitar as Quantidade_Solicitada
	, p.UnidadeMedida as Unidade_De_Medida
	, prod.Preco as Preco_Unitario
	, GETDATE() as Data_Emissao
	, o.DataEmissao as Periodo_Solicitacao
	, o.PrazoEntrega as Periodo_Entrega
	, o.CondicaoPag as Condicao_Pagamento
    , Solicitar * prod.Preco as Total
    , f.Nome as NomeFornecedor
	, f.CPF as CPFFornecedor
	, f.CEP as CEPFornecedor
	, f.Endereco as EnderecoFornecedor
	, f.Bairro as BairroFornecedor
	, f.Cidade as CidadeFornecedor
	, f.Complemento as ComplementoFornecedor
	, f.Estado as EstadoFornecedor
	, f.Complemento2 as Complemento2Fornecedor
	, f.Numero as NumeroFornecedor
	, f.Telefone as TelefoneFornecedor
	, f.Telefone2 as Telefone2Fornecedor
	, f.EMAIL as EmailFornecedor
			FROM PedidoItem p INNER JOIN Orcamento o ON p.IdPedido = o.IdPedido 
							  INNER JOIN Produto prod ON prod.CodigoProduto = p.Cod 
							  INNER JOIN Fornecedor f ON o.Vendedor = f.IdFornecedor
							  WHERE o.IdPedido = @IDPEDIDO
							  GROUP BY p.Cod, p.Nome, p.Solicitar,p.UnidadeMedida,prod.Preco,o.DataEmissao,o.CondicaoPag,o.PrazoEntrega, 
							  f.Nome,f.CPF, f.CEP, f.Endereco, f.Bairro, f.Cidade, f.Complemento, f.Estado,
							  f.Complemento2, f.Numero, f.Telefone, f.Telefone2,f.EMAIL

END																													

