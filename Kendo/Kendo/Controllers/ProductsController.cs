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
using System.Web.Http.Cors;

namespace Kendo.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            var db = new SqlConnection(SqlConnectionString.ConnectionString());

            var products = db.Query<Products>("SELECT * FROM Products");

            return products;
        }


        [HttpPost]
        public void Create(Products item)
        {
            var db = new SqlConnection(SqlConnectionString.ConnectionString());

            db.Execute(
                "INSERT INTO Products ( ProductName,  UnitPrice  , ShelfDate ,Description,CategoryID)" +
                "VALUES ( @productName,  @unitPrice ,@shelfdate ,@description,@categoryID)", new
                {
                    
                    productName = item.ProductName,
                    unitPrice = item.UnitPrice ,
                    shelfdate = item.ShelfDate ,
                    description = item.Description,
                    categoryID = item.CategoryID
                });
        }


        [HttpPost]
        public void Update([FromBody] Products item)
        {
            var db = new SqlConnection(SqlConnectionString.ConnectionString());

            db.Execute("UPDATE Products " +"SET ProductName = @productName " +"WHERE ProductID = @productID", new

                {
                     productID=item.ProductID,
                    productName = item.ProductName
                });
        }

        
        [HttpPost]
        public void Destroy([FromBody] Products item)

        {

            var db = new SqlConnection(SqlConnectionString.ConnectionString());

            db.Execute("delete Products where ProductID=@ProductID", new

            {

                ProductID = item.ProductID

            });

        }

    }
}
