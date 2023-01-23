using System.Net.Http.Json;
using TastePlace.Client.Interfaces;
using TastePlace.Shared.Models;

namespace TastePlace.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;
        private User? loginResult;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async ValueTask<User> Login(User model)
        {
            loginResult = new();
            try
            {
                using var request = await _http.PostAsJsonAsync("api/auth/login", model);
                request.EnsureSuccessStatusCode();
                loginResult = await request.Content.ReadFromJsonAsync<User>();
                return loginResult!;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return loginResult!;
        }

        public async ValueTask<bool> RegisterUser(User user)
        {
            using var request = await _http.PostAsJsonAsync("auth/main", user);
            request.EnsureSuccessStatusCode();
            return request.IsSuccessStatusCode;
        }


        public ValueTask UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
