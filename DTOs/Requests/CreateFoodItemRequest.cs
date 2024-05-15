using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs.Requests
{
    public class CreateFoodItemRequest
    {
        [Required]
        public string food_name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public decimal price { get; set; }
    }
}
