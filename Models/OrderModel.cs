using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingApp.Models
{
    [Table("Orders")]
    public class OrderModel
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long order_id { get; set; }

        [Required]
        public decimal amount { get; set; }

        [Required]
        public long user_id { get; set; }

        [Required]
        public string food_name { get; set; }

        [Required]
        public long restaurant_id { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        [Required]
        public DateTime updated_at { get; set; }



    }
}
