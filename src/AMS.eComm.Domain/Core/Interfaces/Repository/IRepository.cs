using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T: class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        void Update(T entity); 
    }
}