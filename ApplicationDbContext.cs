using FoodOrderingApp.Helpers.Utils.GlobalAttributes;
using FoodOrderingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingApp
{
    public class ApplicationDbContext : DbContext
    {
        //constructors
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //add models to database context
        public virtual DbSet<LoginDetailModel> LoginDetails { get; set; }


        public virtual DbSet<FoodItemModel> FoodItems { get; set; }

        public virtual DbSet<RestaurantModel> Restaurants { get; set; }


        public virtual DbSet<UserModel> Users { get; set; }

        public virtual DbSet<OrderModel> Orders { get; set; }


        //MYSQL configuration to use with default ApplicationDbContext constructor if not configured
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(GlobalAttributes.mysqlConfiguration.connectionString, ServerVersion.AutoDetect(GlobalAttributes.mysqlConfiguration.connectionString));
            }
        }
    }
}
