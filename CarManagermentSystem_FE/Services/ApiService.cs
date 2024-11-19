using CarManagermentSystem_FE.Models;

namespace CarManagermentSystem_FE.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiDataModel> GetDataAsync(string endpoint)
        {
            return await _httpClient.GetFromJsonAsync<ApiDataModel>(endpoint);
        }
    }
}
