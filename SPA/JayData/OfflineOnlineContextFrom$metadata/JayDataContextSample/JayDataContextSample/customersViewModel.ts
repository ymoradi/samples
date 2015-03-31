/// <reference path="appcontext.d.ts" />
/// <reference path="appcontextprovider.ts" />
/// <reference path="scripts/jaydata.d.ts" />

tools.appContextProvider.getContext<JayDataContextSample.Model.AppContext>(true)
    .then((context) => {

    context.Customers.forEach(cust => alert(cust.FirstName));

});