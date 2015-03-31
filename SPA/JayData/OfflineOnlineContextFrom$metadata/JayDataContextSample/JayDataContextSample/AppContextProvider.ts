/// <reference path="scripts/typings/jquery/jquery.d.ts" />

module tools {
    export class appContextProvider {

        private static appContextFactory: any = null;

        private static waitForContextFactory: IPromise<any> = $data['initService']('/odata')
            .then(function (context, contextFactory, contexType) {

            tools.appContextProvider.appContextFactory = contextFactory;

        });

        static getContext<TContext>(offline: boolean): IPromise<TContext> {

            var defer = $.Deferred();

            tools.appContextProvider.waitForContextFactory.then(() => {

                var context = null;

                if (offline) {
                    context = tools.appContextProvider.appContextFactory({ name: 'local', databaseName: 'AppContext' });
                }
                else {
                    context = tools.appContextProvider.appContextFactory('/odata');
                }

                context.onReady(() => {

                    defer.resolve(context);

                });

            });

            return defer.promise();
        }
    }
}