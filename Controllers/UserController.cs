using CLDVSem2Part3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDVSem2Part3.Controllers
{
    public class UserController : Controller
    {
        public UserModel user =new UserModel();



        [HttpPost]
        public ActionResult User(UserModel Users)
        {
            var result = user.insert_User(Users);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult User()
        {
            return View(user);
        }
    }
}
