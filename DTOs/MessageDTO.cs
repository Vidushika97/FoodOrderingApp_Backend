using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs
{
    public class MessageDTO
    {
        [Required]
        public string status { get; set; }
    }
}
