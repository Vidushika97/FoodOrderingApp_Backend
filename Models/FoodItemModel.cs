using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingApp.Models
{
    [Table("Food_Items")]
    public class FoodItemModel
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long food_id { get; set; }

        [Required]
        public string food_name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public int restaurant_id { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        [Required]
        public DateTime updated_at { get; set; }
    }
}
