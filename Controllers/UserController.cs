using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        //controller
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateUser(CreateFoodItemrequest request)
        {
            return userService.CreateUser(request);
        }

        [HttpPut("{id}")]
        public BaseResponse UpdateUserById(long id, UpdateFoodItemRequest request)
        {
            return userService.UpdateUserById(id, request);
        }

        [HttpDelete("{id}")]
        public BaseResponse DeleteUserById(long id)
        {
            return userService.DeleteUserById(id);
        }

    }
}
