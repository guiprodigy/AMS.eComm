namespace AMS.eComm.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        void Update(T entity);
    }
}