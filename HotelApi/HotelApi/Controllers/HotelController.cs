using AutoMapper;
using HotelApi.Core.Models.DTOs;
using HotelApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("api/hotels")]
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;

        public HotelController(IHotelService hotelService, IMapper mapper)
        {
            _hotelService = hotelService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var hotels = await _hotelService.GetAllAsyncWithRoom();

                if (hotels == null || !hotels.Any())
                {
                    return NotFound(new { Message = "No hotels were found in the database." });
                }

                var hotelDTOs = _mapper.Map<IEnumerable<HotelRoomDTO>>(hotels);
                return Ok(hotelDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the hotels.", Details = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { Message = "The hotel ID must be a positive integer." });
            }

            try
            {
                var hotel = await _hotelService.GetByIdWithRoom(id);

                if (hotel == null)
                {
                    return NotFound(new { Message = $"No hotel found with ID {id}." });
                }

                var hotelDTO = _mapper.Map<HotelRoomDTO>(hotel);
                return Ok(hotelDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the hotel.", Details = ex.Message });
            }
        }
    }
}