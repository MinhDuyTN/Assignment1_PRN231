using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Assignment1.Pages
{
    public class WeatherModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public List<WeatherForecast> Forecasts { get; set; }

        public WeatherModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task OnGetAsync()
        {
            // Gọi API để lấy dữ liệu thời tiết
            var response = await _httpClient.GetAsync("https://localhost:7118/WeatherForecast");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                Forecasts = JsonSerializer.Deserialize<List<WeatherForecast>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                Forecasts = new List<WeatherForecast>(); // Hoặc xử lý khi API không trả về thành công
            }
        }
    }


}
