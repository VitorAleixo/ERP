using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AppCode
{
    public static class Relatorio
    {

        public static DataSet Orcamento(int IdPedido)
        {
            localhostCmp.Compras orcamento = new localhostCmp.Compras();

            return orcamento.OrcamentoDataSet(IdPedido);
        }

        public static DataSet CompraCompleta(int IdPedido)
        {
            localhostCmp.Compras CompraCompleta = new localhostCmp.Compras();

            return CompraCompleta.CompraCompletaDataSet(IdPedido);
        }

        public static DataSet Compra(int IdPedido)
        {
            localhostAmx.Almoxarifado compra = new localhostAmx.Almoxarifado();
            
            return compra.CompraDataSet(IdPedido);
        }

    }
}
