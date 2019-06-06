using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using summer19.Model;

namespace summer19.Controllers
{
    public class HomeController : Controller
    {
        private corporate1Context db = new corporate1Context();
        public Login l = new Login();

        [Route("")]
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if(ModelState.IsValid)
            {
                Login usr = db.Login.FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);

                if(usr!=null)
                {
                    HttpContext.Session.SetString("name", login.Username);
                    ViewBag.message = HttpContext.Session.GetString("name");

                    return RedirectToAction("Index","Requirements");
                }
                else
                {
                    ModelState.AddModelError("Error", "ID Password is incorrect");

                    return View();
                }
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }
    }
}
