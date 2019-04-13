using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Repository.Interface;
using UnitOfWorkDemo.Repository.Models;

namespace UnitOfWorkDemo.Repository
{
    public class DoitRepository : Repository<Doit>, IDoitRepository
    {
        public DoitRepository(pichayea_doitContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task CreateAsync(Doit owner)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Doit owner)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Doit>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Doit> GetByIdAsync(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public Task<Doit> GetWithDetailsAsync(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Doit dbOwner, Doit owner)
        {
            throw new NotImplementedException();
        }
    }
}
