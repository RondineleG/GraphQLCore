using GraphQLCore.Contracts;
using GraphQLCore.Entities;

namespace GraphQLCore.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
