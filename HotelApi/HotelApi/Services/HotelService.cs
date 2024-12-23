using HotelApi.Core.Models;
using HotelApi.Repositories;
using HotelApi.Repositories.Interfaces;
using HotelApi.Services.Interfaces;

namespace HotelApi.Services
{
    public class HotelService: GenericService<Hotel>, IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository) : base(hotelRepository)
        {
            this._hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<Hotel>> GetAllAsyncWithRoom()
        {
            return await _hotelRepository.GetAllAsyncWithRoom();
        }
        public async Task<Hotel> GetByIdWithRoom(int id)
        {
            return await _hotelRepository.GetByIdWithRoom(id);
        }
    }
}
