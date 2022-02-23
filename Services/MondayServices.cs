using System.Net.Http.Json;

namespace Mondays.Services
{
    public class MondayServices : IMondayServices
    {
        private readonly HttpClient _httpClient;

        public MondayServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> IsItMonday()
        {
            const string url = "/api/Monday/";
            return await _httpClient.GetFromJsonAsync<bool>(url);
        }
    }
}
