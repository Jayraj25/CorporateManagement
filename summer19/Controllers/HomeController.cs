using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }

        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string receiver, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("", "");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}
