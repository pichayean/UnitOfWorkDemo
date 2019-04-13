using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Model;

namespace UnitOfWorkDemo.Service.Interface
{
    public interface IValueService
    {
        IEnumerable<DoitViewModel> GetDoits();
        IEnumerable<TestViewModel> GetTests();
        void SaveData();
    }
}
