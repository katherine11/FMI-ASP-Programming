using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class PaymentController : Controller
    {
        // GET
        public IActionResult List()
        {
            return View();
        }
    }
}