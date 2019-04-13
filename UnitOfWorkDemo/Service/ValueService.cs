using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Model;
using UnitOfWorkDemo.Service.Interface;

namespace UnitOfWorkDemo.Service
{
    public class ValueService : IValueService
    {
        public IEnumerable<DoitViewModel> GetDoits()
        {
            throw new NotImplementedException();
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
