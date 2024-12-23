using HotelApi.Repositories.Interfaces;
using HotelApi.Services.Interfaces;

namespace HotelApi.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            this._genericRepository = genericRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _genericRepository.GetById(id);
        }

    }
}
