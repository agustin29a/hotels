using System.ComponentModel.DataAnnotations;

namespace HotelApi.Core.Models.DTOs
{
    public class HotelRoomDTO
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? location { get; set; }

        public double rating { get; set; }

        public string? imageUrl { get; set; }

        public List<string>? datesOfTravel { get; set; }

        public string? boardBasis { get; set; }

        public virtual ICollection<RoomDTO> rooms { get; set; }
    }
}
