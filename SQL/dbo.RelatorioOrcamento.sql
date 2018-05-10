USE [Estoque]
GO
/****** Object:  StoredProcedure [dbo].[RelatorioOrcamento]    Script Date: 23/04/2018 14:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[RelatorioOrcamento] @IDPEDIDO INT
AS
BEGIN
SELECT o.Tipo, o.DataEmissao, o.Observacoes, f.Nome as NomeFornecedor,f.CPF,f.CEP,f.Estado,f.Telefone,f.EMAIL, o.PrazoEntrega, o.CondicaoPag, o.ValorAdicional, o.Valor, o.ValorSoma, o.QtdItens, pd.Cod, pd.Nome as NomeProduto, pd.QtdEstoque, pd.QtdMinima, pd.QtdMaxima, pd.Solicitar, pd.UnidadeMedida, p.Preco, p.Preco * pd.Solicitar AS SomaPreco
FROM Orcamento o INNER JOIN Fornecedor f ON f.IdFornecedor = o.Vendedor
INNER JOIN PedidoItem pd ON pd.IdPedido = o.IdPedido
INNER JOIN Produto p ON pd.Cod = p.CodigoProduto
WHERE o.IdPedido = @IDPEDIDO
END