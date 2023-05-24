using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Services;

namespace AMS.eComm.Services.Service
{
    public class ProductService : IBaseService<ProductService>
    {
        private readonly IRepository<ProductService> _repository;
        public ProductService(IRepository<ProductService> repository)
        {
            _repository = repository;
        }
        public async Task Add(ProductService entity)
        {
            await _repository.Add(entity);
        }

        public Task<IEnumerable<ProductService>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductService> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductService entity)
        {
            throw new NotImplementedException();
        }

    }
}