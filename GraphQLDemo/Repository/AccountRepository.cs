using GraphQLDemo.Contracts;
using GraphQLDemo.Entities.Context;

namespace GraphQLDemo.Repository
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
