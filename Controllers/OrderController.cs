using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet("/vendor/index")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);

        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}