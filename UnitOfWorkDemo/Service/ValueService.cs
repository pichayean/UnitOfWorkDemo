using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Model;
using UnitOfWorkDemo.Repository;
using UnitOfWorkDemo.Repository.Interface;
using UnitOfWorkDemo.Repository.Models;
using UnitOfWorkDemo.Service.Interface;

namespace UnitOfWorkDemo.Service
{
    public class ValueService : IValueService
    {
        private IUnitOfWork unitOfWork;

        public ValueService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<DoitViewModel> GetDoits()
        {
            try
            {
                return unitOfWork.GetRepository<IDoitRepository>()
                    .GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .Select(s=>new DoitViewModel {
                        Id = s.Id,
                        Msg= s.Msg,
                        CreateDate=s.CreateDate
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TestViewModel> GetTests()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
