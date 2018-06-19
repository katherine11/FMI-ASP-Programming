using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        // GET
        public IActionResult List()
        {
            return View();
        }
    }
}