using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FoodOrderingApp.Models;

namespace FoodOrderingApp.Models
{
    [Table("Restaurants")]
    public class RestaurantModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long restaurant_id { get; set; }

        [Required]
        public string restaurant_name { get; set; }

        [Required]
        public string location_address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public DateTime created_at { get; set; }

        [Required]
        public DateTime updated_at { get; set; }
    }
}

