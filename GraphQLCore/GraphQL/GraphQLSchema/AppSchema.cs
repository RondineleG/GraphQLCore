using GraphQL;
using GraphQL.Types;
using GraphQLCore.GraphQL.GraphQLQueries;

namespace GraphQLCore.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base (resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
