using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace WebApiApp
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<WebApiApp.Models.Product>("Products");
            var odataModel = builder.GetEdmModel();


            config.MapODataServiceRoute(
                routeName: "defaultOdata",
                routePrefix: "odata",
                model: odataModel,
                batchHandler: new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}