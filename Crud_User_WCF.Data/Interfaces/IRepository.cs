using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
