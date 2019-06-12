using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using summer19.Model;

namespace summer19.Controllers
{
    public class SubmissionListController : Controller
    {
        private readonly corporate1Context _context;
        public corporate1Context db = new corporate1Context();

        public SubmissionListController(corporate1Context context)
        {
            _context = context;
        }

        // GET: SubmissionList
        [Route("spec")]
        public  IActionResult Index(string id)
        {
            string session = HttpContext.Session.GetString("name");

            if (session == null)
            {
                return RedirectToAction(nameof(Login));
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }
                else
                {
                    var data = db.Candidate.FromSql("Select * from candidate where Departement = @p0", id);
                    return View("~/Views/SubmissionList/Index.cshtml",data);
                }
            }
        }

        public ActionResult Assign()
        {
            string session = HttpContext.Session.GetString("name");

            if (session == null)
            {
                return RedirectToAction(nameof(Login));
            }
            var data = db.Candidate.FromSql("select * from Candidate");
            return View(data);
        }
            
    }

}

