using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingBlazor.Data.Entities
{

    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomTypeId { get; set; }

        [Required, MaxLength(25), Unicode(false)]
        public string RoomNumber { get; set; }

        public bool IsAvailable { get; set; }

        public virtual RoomType RoomType { get; set; } 

    }
} 
