namespace HotelBookingBlazor.Data.Entities
{
    public class RoomTypeAmenity 
    {
        public int RoomTypeId { get; set; }
        public int AmenityTypeId { get; set; }
        public int? Unit { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual Amenity Amenity { get; set; }

    }
} 
