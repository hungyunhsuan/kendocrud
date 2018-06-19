using Dapper;
using Kendo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kendo.Controllers
{
    [RoutePrefix("kendo")]
    public class ProductsController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            var db = new SqlConnection(SqlConnectionString.ConnectionString());

            var products = db.Query<Products>("SELECT * FROM Products");

            return products;
        }
    }
}
