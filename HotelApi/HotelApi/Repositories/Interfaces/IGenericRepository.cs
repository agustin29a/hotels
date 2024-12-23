using System.Linq.Expressions;

namespace HotelApi.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetById(int id);
    }
}
