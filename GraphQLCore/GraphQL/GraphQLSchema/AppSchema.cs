using GraphQL;
using GraphQL.Types;

namespace GraphQLCore.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base (resolver)
        {
                
        }
    }
}
