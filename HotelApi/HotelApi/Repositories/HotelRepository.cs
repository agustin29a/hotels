using HotelApi.Core.Models;
using HotelApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Repositories
{
    public class HotelRepository: GenericRepository<Hotel>, IHotelRepository
    {

        private IUnitOfWork _unitOfWork;
        public HotelRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;

        }

        public async Task<IEnumerable<Hotel>> GetAllAsyncWithRoom()
        {
            return await _unitOfWork.Context.Set<Hotel>().Include(h => h.rooms).ToListAsync();
        }

        public async Task<Hotel> GetByIdWithRoom(int id)
        {
            return await _unitOfWork.Context.Set<Hotel>().Include(h => h.rooms).FirstOrDefaultAsync(h => h.id == id);
        }


    }
}
