using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Repository.Interface;
using UnitOfWorkDemo.Repository.Models;
//https://stackoverflow.com/questions/50672488/dependency-injection-to-unit-of-work

namespace UnitOfWorkDemo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private pichayea_doitContext db;

        public UnitOfWork() : this(new pichayea_doitContext()) { }

        public UnitOfWork(pichayea_doitContext dbContext)
        {
            db = dbContext;
        }

        public T GetRepository<T>() where T : class
        {
            var result = (T)Activator.CreateInstance(typeof(T), db);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
