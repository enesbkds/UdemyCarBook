using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarBook.Dto.RentACarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    [AllowAnonymous]
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {

            var locationID = TempData["locationID"];

            //filterRentACarDto.locationID = int.Parse(locationID.ToString());
            //filterRentACarDto.avaliable = true;
            if (locationID != null && int.TryParse(locationID.ToString(), out int tempLocationId))
            {
                id = tempLocationId;
            }

            ViewBag.locationID = locationID;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7112/api/RentACars?locationID={id}&avaliable=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
