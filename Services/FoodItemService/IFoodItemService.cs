using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;

namespace FoodOrderingApp.Services.FoodItemService
{
    public interface IFoodItemService
    {
        BaseResponse CreateFoodItem(CreateFoodItemRequest request);
        BaseResponse DeleteFoodItemById(long id);
        BaseResponse UpdateFoodItemById(long id, UpdateItemRequest request);
    }
}
