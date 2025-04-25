using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingBlazor.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Required, MaxLength(10), RegularExpression(@"^[a-zA-Z]+$"), Unicode(false)]
        public string firstName { get; set; }
        [MaxLength(10), Unicode(false)]
        public string lastName { get; set; }
        [Required, MaxLength(8), Unicode(false)]
        public string RoleName { get; set; }
        
        [Required, MaxLength(15), RegularExpression(@"[^0-9\+\(\)\]\s]")]
        public string ContactNumber { get; set; }
        [Required, Unicode(false)]
        public string? Designation { get; set; }

        [Required, Unicode(false)]
        public string? Image { get; set; }
        
    }

}
