using FoodOrderingApp.DTOs.Requests;
using FoodOrderingApp.DTOs.Responses;

namespace FoodOrderingApp.Services.AuthService
{
    public interface IAuthService
    {
        BaseResponse Authenticate(AuthenticateRequest request);

        String GetMD5Hash(string input);
    }
}
