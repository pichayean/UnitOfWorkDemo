using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Repository.Models;

namespace UnitOfWorkDemo.Repository.Interface
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetAllAsync();
        Task<Doit> GetByIdAsync(Guid ownerId);
        Task<Doit> GetWithDetailsAsync(Guid ownerId);
        Task CreateAsync(Doit owner);
        Task UpdateAsync(Doit dbOwner, Doit owner);
        Task DeleteAsync(Doit owner);
    }
}
