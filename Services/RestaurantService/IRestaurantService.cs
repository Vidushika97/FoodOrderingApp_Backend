using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;

namespace FoodOrderingApp.Services.RestaurantService
{
    public interface IRestaurantService
    {
        BaseResponse CreateRestaurant(CreateRestaurantRequest request);
        BaseResponse DeleteRestaurantById(long id);
    }
}
