using HotelApi.Core.Models;

namespace HotelApi.Repositories.Interfaces
{
    public interface IHotelRepository: IGenericRepository<Hotel> 
    {
        Task<IEnumerable<Hotel>> GetAllAsyncWithRoom();
        Task<Hotel> GetByIdWithRoom(int id);
    }
}
