using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs.Requests
{
    public class AuthenticateRequest
    {
        [Required]
        public string username { get; set; }
    
        [Required]
        public string password { get; set; }
    }
}


