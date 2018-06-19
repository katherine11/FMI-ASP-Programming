using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ClientController : Controller
    {
        // GET
        public IActionResult List()
        {
            return View();
        }
    }
}