using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.Models
{
    [Table("Login_Details")]
    public class LoginDetailModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required]
        public long user_id { get; set; }

        [Required]
        public string token { get; set; }

        [Required]
        public DateTime updated_at { get; set; }

        [Required]
        public DateTime created_at { get; set; }
    }
}

