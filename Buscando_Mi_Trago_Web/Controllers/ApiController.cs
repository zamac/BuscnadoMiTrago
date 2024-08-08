using Microsoft.AspNetCore.Mvc;
using Buscandomitrago.Domain;
using Buscandomitrago.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Buscandomitrago.Domain.Utils;
using Buscandomitrago.Application.IServices;
using Microsoft.AspNetCore.JsonPatch.Internal;
namespace Buscando_Mi_Trago_Web.Controllers
{
    public class ApiController : Controller
    {
        private readonly IApiService _apiService;

        public ApiController(IApiService apiService)
        {
            _apiService = apiService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateDrink([FromBody] Drink drink)
        {
            await _apiService.CreateDrink(drink);
            return StatusCode(200);
        }

        [HttpGet]
        public  JsonResult GetMydrinks()
        {
           List<DrinksView> myDrinks =  _apiService.GetMydrinks();
            return Json(myDrinks);
        }
    }
}
