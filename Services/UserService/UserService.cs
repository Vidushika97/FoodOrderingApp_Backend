using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;
using FoodOrderingApp.Models;
using FoodOrderingApp.Services.AuthService;

namespace FoodOrderingApp.Services.UserService
{
    public class UserService : IUserService
    {
       
        
            //variable to store application db context
            private readonly ApplicationDbContext context;
            private readonly IAuthService authService;


        public UserService(ApplicationDbContext applicationDbContext)
            {
                //get db context through DI
                context = applicationDbContext;
                this.authService = authService;

        }
        public BaseResponse CreateUser(CreateFoodItemrequest request)
        {
            BaseResponse response;

            try
            {

                // create new instace of user model

                UserModel newUser = new UserModel();
                newUser.first_name = request.first_name;
                newUser.last_name = request.last_name;
                newUser.email = request.email;
                newUser.contact_number = request.contact_number;
                newUser.user_address = request.user_address;
                newUser.username = request.username;
                newUser.password = authService.GetMD5Hash(request.password);


                using (context)
                {
                    context.Add(newUser);
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

        public BaseResponse DeleteUserById(long id)
        {
            BaseResponse response;

            try
            {
                using (context)
                {
                    UserModel userToDelete = context.Users.Where(user => user.user_id == id).FirstOrDefault();

                    if (userToDelete != null)

                    {
                        context.Users.Remove(userToDelete);
                        context.SaveChanges();


                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status200OK,
                            data = new { message = "User deleted successfully" }
                        };
                    }
                    else
                    {
                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status400BadRequest,
                            data = new { message = "No user found" }
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

        public BaseResponse UpdateUserById(long id, UpdateFoodItemRequest request)
        {
            BaseResponse response;

            try
            {
                using (context)
                {
                    UserModel filteredUser = context.Users.Where(user => user.user_id == id).FirstOrDefault();

                    if (filteredUser != null)
                    {
                        filteredUser.first_name = request.first_name;
                        filteredUser.last_name = request.last_name;
                        filteredUser.user_address = request.user_address;
                        filteredUser.email = request.email;
                        filteredUser.contact_number = request.contact_number;
                        filteredUser.user_address = request.user_address;
                        filteredUser.username = request.username;



                        context.SaveChanges();

                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status200OK,
                            data = new { message = "User updated successfully" }
                        };
                    }

                    else
                    {
                        response = new BaseResponse
                        {
                            status_code = StatusCodes.Status400BadRequest,
                            data = new { message = "No user found" }
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

