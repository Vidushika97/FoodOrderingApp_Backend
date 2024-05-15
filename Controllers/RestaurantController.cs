using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Services.RestaurantService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService restaurantService;

        //controller
        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateRestaurant(CreateRestaurantRequest request)
        {
            return restaurantService.CreateRestaurant(request);
        }


        [HttpDelete("{id}")]
        public BaseResponse DeleteRestaurantById(long id)
        {
            return restaurantService.DeleteRestaurantById(id);
        }
    }
}
