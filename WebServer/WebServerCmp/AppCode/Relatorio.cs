using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServerCmp.AppCode
{
    public static class Relatorio
    {
        public static DataSet Orcamento(int IdPedido)
        {
            DataSetOrcamento dsOrcamento = new DataSetOrcamento();
            return dsOrcamento.RetornarDataSet(IdPedido);
            
        }
    }
}