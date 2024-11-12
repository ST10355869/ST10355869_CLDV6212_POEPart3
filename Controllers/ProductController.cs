using Microsoft.AspNetCore.Mvc;
using CLDVSem2Part3.Models;

namespace CLDVSem2Part3.Controllers
{
    public class ProductController : Controller
    {
        public ProductModel product = new ProductModel();



        [HttpPost]
        public ActionResult Privacy(ProductModel products)
        {
            var result = product.Insert_Product(products);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Privacy()
        {
            return View(product);
        }
    }
}
