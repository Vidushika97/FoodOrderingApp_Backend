using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Models;

namespace FoodOrderingApp.Services.FoodItemService
{
    public class FoodItemService : IFoodItemService
    {

        //variable to store application db context
        private readonly ApplicationDbContext context;


        public FoodItemService(ApplicationDbContext applicationDbContext)
        {
            //get db context through DI
            context = applicationDbContext;

        }
        public BaseResponse CreateFoodItem(CreateFoodItemRequest request)
        {
            BaseResponse response;

            try
            {

                // create new instace of  model

                FoodItemModel newFoodItem = new FoodItemModel();
                newFoodItem.food_name = request.food_name;
                newFoodItem.description = request.description;
                newFoodItem.price = request.price;
                


                using (context)
                {
                    context.Add(newFoodItem);
                    context.SaveChanges();

                }

                response = new BaseResponse
                {
                    status_code = StatusCodes.Status200OK,
                    data = new { message = "Successfully created the Item" }
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

        public BaseResponse DeleteFoodItemById(long id)
        {
            BaseResponse response;

            try
            {
                using (context)
                {
                    FoodItemModel foodToDelete = context.FoodItems.Where(food => food.food_id == id).FirstOrDefault();

                    if (foodToDelete != null)

                    {
                        context.FoodItems.Remove(foodToDelete);
                        context.SaveChanges();


                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status200OK,
                            data = new { message = "Item deleted successfully" }
                        };
                    }
                    else
                    {
                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status400BadRequest,
                            data = new { message = "No Item found" }
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

        public BaseResponse UpdateFoodItemById(long id, UpdateItemRequest request)
        {
            BaseResponse response;

            try
            {
                using (context)
                {
                    FoodItemModel filteredFoodItem = context.FoodItems.Where(food => food.food_id == id).FirstOrDefault();

                    if (filteredFoodItem != null)
                    {
                        filteredFoodItem.food_name = request.food_name;
                        filteredFoodItem.description = request.description;
                        filteredFoodItem.price = request.price;
                        


                        context.SaveChanges();

                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status200OK,
                            data = new { message = "Item updated successfully" }
                        };
                    }

                    else
                    {
                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status400BadRequest,
                            data = new { message = "No Item found" }
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

                return response;
            }
        }
    }
}
