using Microsoft.AspNetCore.Mvc;

namespace Stripe.Api.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
