using HotelApi.Core.Models;

namespace HotelApi.Services.Interfaces
{
    public interface IHotelService: IGenericService<Hotel>
    {
        Task<IEnumerable<Hotel>> GetAllAsyncWithRoom();
        Task<Hotel> GetByIdWithRoom(int id);
    }
}
