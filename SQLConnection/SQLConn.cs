using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Webangular.SQLConnection
{
    public class SQLConn
    {
        public IDbConnection CreateConnection(string name = "default")
        {
            switch (name)
            {
                case "default":
                    {
                        var ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Connstr"].ConnectionString;

                        return new SqlConnection(ConnectionString);
                    }
                default:
                    {
                        throw new Exception("name 不存在。");
                    }
            }
        }
    }
}