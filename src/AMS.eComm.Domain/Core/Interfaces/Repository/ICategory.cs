namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface ICategory : IRepository<Entities.Category>
    {
        void Delete(Guid id);
    }
}