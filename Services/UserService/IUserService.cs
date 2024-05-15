using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;

namespace FoodOrderingApp.Services.UserService
{
    public interface IUserService
    {
        BaseResponse CreateUser(CreateFoodItemrequest request);
        BaseResponse DeleteUserById(long id);
        BaseResponse UpdateUserById(long id, UpdateFoodItemRequest request);
    }
}
