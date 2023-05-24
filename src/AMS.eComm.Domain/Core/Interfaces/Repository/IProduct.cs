namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IProduct : IRepository<Entities.Product>
    {
        void Delete(Guid id);
    }
}