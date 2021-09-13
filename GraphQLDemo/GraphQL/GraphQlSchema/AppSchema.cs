using GraphQL.Types;
using GraphQL.Utilities;
using GraphQLDemo.GraphQL.GraphQLQueries;
using System;

namespace GraphQLDemo.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
