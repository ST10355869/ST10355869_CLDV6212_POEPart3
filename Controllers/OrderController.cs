using CLDVSem2Part3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDVSem2Part3.Controllers
{
    public class OrderController : Controller
    {
        public OrderModel order = new OrderModel();



        [HttpPost]
        public ActionResult Index(OrderModel Order)
        {
            var result = order.insert_order(Order);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(order);
        }
    }
}
