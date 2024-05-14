using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs
{
    public class FoodItemDTO
    {
        [Required]
        public string food_name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public decimal price { get; set; }
    }
}
