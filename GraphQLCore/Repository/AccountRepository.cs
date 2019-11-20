using GraphQLCore.Contracts;
using GraphQLCore.Entities;

namespace GraphQLCore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;

        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
