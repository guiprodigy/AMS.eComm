using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;

namespace AMS.eComm.Infra.Data.Repository
{
    public class ProductRepository : IProduct
    {
        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}