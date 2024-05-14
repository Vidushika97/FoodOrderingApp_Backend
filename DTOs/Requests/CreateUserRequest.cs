using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs.Requests
{
    public class CreateUserRequest
    {
        [Required]
        public string role { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
