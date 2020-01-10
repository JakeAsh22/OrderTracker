using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}