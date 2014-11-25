using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class ProductsController : ODataController
    {
        [EnableQuery(MaxNodeCount = 1000)]
        public IHttpActionResult Get()
        {
            return Ok(new List<Product>
            {
                new Product { Id = 1, Name = "A" },
                new Product { Id = 2, Name = "B" },
                new Product { Id = 3, Name = "C" }
            });
        }
    }
}