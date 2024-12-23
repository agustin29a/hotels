using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Core.Models
{
    public class Room
    {

        public int Id { get; set; }
        public string? roomType { get; set; }
        public int? amount { get; set; }

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
    }
}
