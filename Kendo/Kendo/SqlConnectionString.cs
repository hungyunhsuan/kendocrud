using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo
{
    public class SqlConnectionString
    {
        public static string ConnectionString()
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("SQLAZURECONNSTR_Commerce")))
            {
                return Environment.GetEnvironmentVariable("SQLAZURECONNSTR_Commerce");
            }
            else
            {
                return "data source=.; database=Commerce; integrated security=true";
            }
        }
    }
}