using AutoMapper;
using AutoMapper.Execution;
using HotelApi.Core.Models;
using HotelApi.Core.Models.DTOs;

namespace HotelApi.Core.Mapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<Hotel, HotelRoomDTO>();
            CreateMap<Room, RoomDTO>();
        }

    }
}
