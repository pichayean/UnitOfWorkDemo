using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Repository.Interface;
using UnitOfWorkDemo.Repository.Models;

namespace UnitOfWorkDemo.Repository
{
    public class TestRepository : Repository<Test>, ITestRepository
    {
        public TestRepository(pichayea_doitContext repositoryContext) : base(repositoryContext)
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

        public Task<IEnumerable<Test>> GetAllAsync()
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
