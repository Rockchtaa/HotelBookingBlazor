using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingBlazor.Data.Entities
{
    public class RoomType
    {
        public int Id { get; set; }

        [Required, MaxLength(25), Unicode(false)]
        public string Image { get; set; }

        [Required, Range(1, double.MaxValue)]
        public decimal Price { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string? LastUpdatedBy { get; set; }
        [ForeignKey(nameof(AddedBy))]
        public virtual ApplicationUser AddedByUser { get; set; }

        public virtual ICollection<RoomTypeAmenity> Amenities { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
} 
