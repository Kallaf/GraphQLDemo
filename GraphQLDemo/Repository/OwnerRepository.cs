using GraphQLDemo.Contracts;
using GraphQLDemo.Entities;
using GraphQLDemo.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLDemo.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;
        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Owner> GetAll() => _context.Owners.ToList();
    }
}
