using GraphQLDemo.Entities;
using System.Collections.Generic;

namespace GraphQLDemo.Contracts
{
	public interface IOwnerRepository
	{
		IEnumerable<Owner> GetAll();
	}
}
