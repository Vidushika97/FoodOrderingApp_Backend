using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs.Requests
{
    public class CreateRestaurantRequest
    {
        [Required]
        public string restaurant_name { get; set; }

        [Required]
        public string location_address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
