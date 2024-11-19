using CarManagermentSystem_FE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarManagermentSystem_FE.Pages
{
    public class LoginModel : PageModel
    {
        private readonly HttpClient _httpClient;

        [BindProperty]
        public LoginDTO LoginDTO { get; set; }
        public LoginModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string haha = "hahahahahahaa";
        //public async Task<IActionResult> OnGet()
        //{
        //    //var response = await _httpClient.GetAsync("https://api.example.com/data");
        //    //if (response.IsSuccessStatusCode)
        //    //{
        //    //    var data = await response.Content.ReadAsStringAsync();
        //    //}
        //    //return Page();
        //}
    }
}
