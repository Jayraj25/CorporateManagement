using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using summer19.Model;

namespace summer19.Controllers
{
    public class AssignCandidateController : Controller
    {
        public corporate1Context db = new corporate1Context();

        private readonly IHostingEnvironment he;

        public AssignCandidateController(IHostingEnvironment e)
        {
            he = e;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string session = HttpContext.Session.GetString("name");
            if (session != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpPost]
        public IActionResult Index(string req,string pos,string loc)
        {
            string session = HttpContext.Session.GetString("name");

            if (session == null)
            {
                return RedirectToAction(nameof(Login));
            }
            else
            {
                string require = req;
                string position = pos;
                string location = loc;
                if (require != "" && position == "" && location == "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Departement= {require}");
                    return View(data);
                }
                else if (require != "" && position != "" && location == "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Departement = {require} and Positon = {position}");
                    return View(data);
                }
                else if (require == "" && position != "" && location == "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Position = {position}");
                    return View(data);
                }
                else if (require == "" && position == "" && location != "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Location = {location}");
                    return View(data);
                }
                else if (require != "" && position == "" && location != "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Departement = {require} and Location = {location}");
                    return View(data);
                }
                else if (require == "" && position != "" && location != "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Position = {position} and Location = {location}");
                    return View(data);
                }
                else if (require != "" && position != "" && location != "")
                {
                    var data = db.Requirements.FromSql("select * from Requirements where Departement = {require} and Position = {position} and  Location = {location}");
                    return View(data);
                }
                else
                {
                    var data = db.Requirements.FromSql("select * from Requirements");
                    return View(data);
                }
            }
        }
    }
}
