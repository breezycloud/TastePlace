using TastePlace.Client.Interfaces;

namespace TastePlace.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;

        public OrderService(HttpClient http)
        {
            _http = http;
        }
    }
}
