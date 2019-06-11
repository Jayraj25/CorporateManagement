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
    [Route("SubmissionList")]
    public class SubmissionListController : Controller
    {
        private readonly corporate1Context _context;
        public corporate1Context db = new corporate1Context();

        public SubmissionListController(corporate1Context context)
        {
            _context = context;
        }

        // GET: SubmissionList
        [HttpGet("/Index/{Departement}")]
        //[HttpGet("{Departement}")]
        public  IActionResult Index(string Departement)
        {
            string session = HttpContext.Session.GetString("name");

            if (session == null)
            {
                return RedirectToAction(nameof(Login));
            }
            else
            {
                if (Departement == null)
                {
                    return NotFound();
                }
                else
                {
                    var data = db.Candidate.FromSql("Select * from candidate where Departement = @p0", Departement);
                    return View(data);
                }
                   /* var depart = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Departement == dept);
                    if (depart == null)
                    {
                        return NotFound();
                    }
                var data = db.Candidate.FromSql("select * from Candidate");
                return View(data);*/
            }
        }
            
    }

}

