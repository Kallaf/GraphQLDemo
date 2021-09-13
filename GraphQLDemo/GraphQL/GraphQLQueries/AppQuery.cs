using GraphQL.Types;
using GraphQLDemo.Contracts;
using GraphQLDemo.GraphQL.GraphQLTypes;

namespace GraphQLDemo.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IOwnerRepository repository)
        {
            Field<ListGraphType<OwnerType>>(
               "owners",
               resolve: context => repository.GetAll()
           );
        }
    }
}
