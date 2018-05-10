USE [Estoque]
GO
/****** Object:  StoredProcedure [dbo].[RelatorioSolicitacao]    Script Date: 23/04/2018 14:34:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RelatorioSolicitacao] @IDPEDIDO INT
AS
BEGIN
SELECT p.Solicitante, p.Urgencia, p.Motivo, p.DataCriacao, p.Tipo, pd.Cod, pd.Nome, pd.Solicitar, pd.UnidadeMedida,pr.Preco, pr.Preco * pd.Solicitar AS PrecoTotal
				 FROM Pedido p INNER JOIN PedidoItem pd ON p.IdPedido = pd.IdPedido 
				 INNER JOIN Produto pr ON pd.Cod = pr.CodigoProduto 
				 WHERE p.IdPedido = @IDPEDIDO;
END
