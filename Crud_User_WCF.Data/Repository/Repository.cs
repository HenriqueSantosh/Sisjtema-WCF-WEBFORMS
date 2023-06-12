using Crud_User_WCF.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SistemaContext _dbContex = new SistemaContext();
        protected readonly DbSet<TEntity> DbSet;

        public Repository()
        {
            DbSet = _dbContex.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            this.DbSet.Add(obj);
            _dbContex.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            this.DbSet.Remove(obj);
            _dbContex.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            this.DbSet.Update(obj);
            _dbContex.SaveChanges();

        }

        public void Dispose()
        {
            _dbContex.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
