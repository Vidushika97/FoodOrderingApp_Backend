using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Models;

namespace FoodOrderingApp.Services.RestaurantService
{
    public class RestaurantService : IRestaurantService
    {

        //variable to store application db context
        private readonly ApplicationDbContext context;


        public RestaurantService(ApplicationDbContext applicationDbContext)
        {
            //get db context through DI
            context = applicationDbContext;

        }
        public BaseResponse CreateRestaurant(CreateRestaurantRequest request)
        {
            BaseResponse response;

            try
            {

                // create new instace of user model

                RestaurantModel newRestaurant = new RestaurantModel();
                newRestaurant.restaurant_name = request.restaurant_name;
                newRestaurant.location_address = request.location_address;
                newRestaurant.PhoneNumber = request.PhoneNumber;
  
                

               

                using (context)
                {
                    context.Add(newRestaurant);
                    context.SaveChanges();

                }

                response = new BaseResponse
                {
                    status_code = StatusCodes.Status200OK,
                    data = new { message = "Successfully created the new user" }
                };

                return response;
            }
            catch (Exception ex)
            {
                response = new BaseResponse
                {
                    status_code = StatusCodes.Status500InternalServerError,
                    data = new { message = "Internal server error : " + ex.Message }
                };

                return response;
            }
        }

        public BaseResponse DeleteRestaurantById(long id)
        {
            BaseResponse response;

            try
            {
                using (context)
                {
                    RestaurantModel restaurantToDelete = context.Restaurants.Where(restaurant => restaurant.restaurant_id == id).FirstOrDefault();

                    if (restaurantToDelete != null)

                    {
                        context.Restaurants.Remove(restaurantToDelete);
                        context.SaveChanges();


                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status200OK,
                            data = new { message = "Restaurant deleted successfully" }
                        };
                    }
                    else
                    {
                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status400BadRequest,
                            data = new { message = "No restaurant found" }
                        };
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                response = new BaseResponse
                {
                    status_code = StatusCodes.Status500InternalServerError,
                    data = new { message = "Internal server error : " + ex.Message }
                };
            }
            return response;
        }

        

    }
}

