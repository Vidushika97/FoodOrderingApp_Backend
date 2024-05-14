﻿using System.ComponentModel.DataAnnotations;

namespace FoodOrderingApp.DTOs
{
    public class OrderDTO
    {
        public long order_id { get; set; }

        [Required]
        public decimal amount { get; set; }

        [Required]
        public long user_id { get; set; }

        [Required]
        public string food_name { get; set; }

        [Required]
        public long restaurant_id { get; set; }
    }
}
