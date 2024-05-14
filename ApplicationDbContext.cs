using FoodOrderingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingApp
{
    public class ApplicationDbContext : DbContext
    {
        //constructors

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //add models to database context
        public virtual DbSet<LoginDetailModel> LoginDetails { get; set; }


        public virtual DbSet<FoodItemModel> FoodItems { get; set; }

        public virtual DbSet<RestaurantModel> Restaurants { get; set; }


        public virtual DbSet<UserModel> Users { get; set; }
    }
}
