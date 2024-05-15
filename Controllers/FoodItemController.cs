using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Services.FoodItemService;
using FoodOrderingApp.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemService foodService;

        //controller
        public FoodItemController(IFoodItemService foodService)
        {
            this.foodService = foodService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateFoodItem(CreateFoodItemRequest request)
        {
            return foodService.CreateFoodItem(request);
        }

        [HttpPut("{id}")]
        public BaseResponse UpdateFoodItemById(long id, UpdateItemRequest request)
        {
            return foodService.UpdateFoodItemById(id, request);
        }

        [HttpDelete("{id}")]
        public BaseResponse DeleteFoodItemById(long id)
        {
            return foodService.DeleteFoodItemById(id);
        }
    }
}
