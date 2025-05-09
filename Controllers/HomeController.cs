using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OP.Models;
using OP.Service;

namespace OP.Controllers
{
    public class HomeController : Controller

    {
        private readonly IOrderDetails _orderDetails;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , IOrderDetails orderDetails)
        {
            _logger = logger;
            _orderDetails = orderDetails;
        }


        public IActionResult OrdersForm()
        {
            return View();
        }

        public IActionResult OrderDetails()
        {
            var orderDetails = _orderDetails.GetOrderDetails();
            return View(orderDetails);
        }

        public IActionResult AddOrder(Orders order)
        {
            _orderDetails.SetOrderDetails(order);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
