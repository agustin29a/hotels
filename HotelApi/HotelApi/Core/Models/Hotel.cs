using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelApi.Core.Models
{
    public class Hotel
    {
        [Key]
        public int id { get; set; }

        public string? name { get; set; }

        [StringLength(50)]
        public string? location { get; set; }

        public double rating { get; set; }

        [StringLength(50)]
        public string? imageUrl { get; set; }

        [StringLength(50)]
        public string? boardBasis { get; set; }

        public List<string>? datesOfTravel { get; set; }
       
        public virtual ICollection<Room> rooms { get; set; } 

    }
}
