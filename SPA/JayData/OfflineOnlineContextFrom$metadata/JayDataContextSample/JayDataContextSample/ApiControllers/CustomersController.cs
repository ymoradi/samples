using JayDataContextSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData;

namespace JayDataContextSample.ApiControllers
{
    public class CustomersController : EntitySetController<Customer, int>
    {
        public override IQueryable<Customer> Get()
        {
            return new Customer[]
            {
                new Customer { Id = 1, FirstName = "Test1" , LastName = "Test1" },
                new Customer { Id = 2, FirstName = "Test2" , LastName = "Test2" }
            }.AsQueryable();
        }
    }
}