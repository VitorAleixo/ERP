using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class ConnectionFactory
    {
        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection("Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
        }
    }
}