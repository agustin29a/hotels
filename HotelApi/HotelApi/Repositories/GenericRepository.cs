using HotelApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _unitOfWork.Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _unitOfWork.Context.Set<T>().FindAsync(id);
        }
    }
}
