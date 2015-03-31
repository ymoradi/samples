using System;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.OData.Batch;
using System.Web.Http.OData.Extensions;
using Microsoft.Data.Edm;
using Owin;
using System.Web.Http.OData.Formatter;
using Microsoft.Owin;
using JayDataContextSample;
using System.Web.Http.OData.Builder;
using JayDataContextSample.Model;

[assembly: OwinStartup(typeof(AppStartup))]

namespace JayDataContextSample
{
    public class AppStartup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfig = new HttpConfiguration();

            HttpServer server = new HttpServer();

            ODataModelBuilder modelBuilder = new ODataConventionModelBuilder();

            modelBuilder.Namespace = typeof(Customer).Namespace;

            modelBuilder.ContainerName = "AppContext";

            modelBuilder.EntitySet<Customer>("Customers");

            IEdmModel model = modelBuilder.GetEdmModel();

            httpConfig.Routes.MapODataServiceRoute("odata", "odata", model);

            httpConfig.AddODataQueryFilter();

            app.UseWebApi(httpConfig);
        }
    }
}
