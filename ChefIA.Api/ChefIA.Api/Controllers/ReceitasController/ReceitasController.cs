using Microsoft.AspNetCore.Mvc;

namespace ChefIA.Api.Controllers.ReceitasController
{
    [ApiController]
    [Route("[receitas]")]
    public class ReceitasController : Controller
    {
        [HttpGet("/cafe-da-manha")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
