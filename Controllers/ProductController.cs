using Microsoft.AspNetCore.Mvc;
using CLDVSem2Part3.Models;

namespace CLDVSem2Part3.Controllers
{
    public class ProductController : Controller
    {
        public ProductModel product = new ProductModel();



        [HttpPost]
        public ActionResult MyWork(ProductModel products)
        {
            var result2 = product.insert_product(products);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult MyWork()
        {
            return View(product);
        }
    }
}
