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
    public class FiltersController : Controller
    {
        private const string V = "";
        public corporate1Context db = new corporate1Context();

        private readonly IHostingEnvironment he;

        public FiltersController(IHostingEnvironment e)
        {
            he = e;
        }

        // GET: Filters
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


        // POST: Filters/Create
        [HttpPost]
        public ActionResult Index(string selectreq,string selectpos,string selectloc)
        {
            string session = HttpContext.Session.GetString("name");

            if (session == null)
            {
                return RedirectToAction(nameof(Login));
            }
            else
            {
                try
                {
                    ViewData["selectreq"] = selectreq;
                    ViewData["selectpos"] = selectpos;
                    ViewData["selectloc"] = selectloc;
                    var require = ViewData["selectreq"];
                    var position = ViewData["selectpos"];
                    var jobcat = ViewData["selectloc"];
                    /*string require = filter.Req;
                string position = filter.Pos;
                string jobcat = filter.Loc;*/

                    if (require != V && position == V && jobcat == V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Departement= {require}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require != V && position != V && jobcat == V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Departement = {require} and Jobtitle = {position}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require == V && position != V && jobcat == V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Jobtitle = {position}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require == V && position == V && jobcat != V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Jobcategory = {jobcat}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require != V && position == V && jobcat != V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Departement = {require} and Jobcategory = {jobcat}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require == V && position != V && jobcat != V)
                    {
                        var data = db.Candidate.FromSql("select * from Candidate where Jobtitle = {position} and Jobcategory = {jobcat}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else if (require != V && position != V && jobcat != V)
                    {
                        IQueryable<Candidate> data = db.Candidate.FromSql("select * from Candidate where Departement = {require} and Jobtitle = {position} and  Jobcategory = {jobcat}");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                    else
                    {
                        var data = db.Candidate.FromSql("select * from Candidate");
                        return View("~/Views/AssignCandidate/Index.cshtml", data);
                    }
                }
                catch
                {
                    return View();
                }                

            }
        }
    }
}
