using GraphQLCore.Entities;
using System.Collections.Generic;

namespace GraphQLCore.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
    }
}
