using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerCmp.AppCode
{
    public class ConnectionFactory
    {
        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection("Data Source=VAIO;Initial Catalog=Estoque;User ID=sa;Password=sa");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
        }
    }
}