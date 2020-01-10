using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class OrderTrackerController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}