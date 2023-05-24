namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IColor : IRepository<Entities.Color>
    {
        void Delete(Guid id);
    }

}