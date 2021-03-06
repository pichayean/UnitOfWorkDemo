﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Repository.Models;

namespace UnitOfWorkDemo.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        T GetRepository<T>() where T : class;
        void Save();
    }
}
