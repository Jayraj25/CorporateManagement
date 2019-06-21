using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    public class CandidatesaddController : Controller
    {

        public corporate1Context db = new corporate1Context();
        private readonly IHostingEnvironment he;
        public CandidatesaddController(IHostingEnvironment e)
        {
            he = e;
        }

        // GET: Candidates/Create
        [HttpGet]
        public IActionResult Create()
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

        // POST: Candidates/Create
        [HttpPost]
        public ActionResult Create(DataFile filesave, Candidate candidate, IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    filesave.Path = "No File Exist";
                }

                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot" + "/Files/", Path.GetFileName(file.FileName));
                    file.CopyTo(new FileStream(path, FileMode.Create));
                    // var stream = new FileStream(path, FileMode.Create);
                    filesave.Path = "/" + Path.GetFileName(file.FileName);
                    filesave.Extension = Path.GetExtension(file.FileName);
                    candidate.Resumes = Path.GetFileName(file.FileName);
                }
                db.Candidate.Add(candidate);
                db.DataFile.Add(filesave);
                int i = db.SaveChanges();
                if (i == 1)
                {
                    return RedirectToAction("Index", "Candidates");
                }
                else
                {
                    return RedirectToAction("Index", "Candidates");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                //ViewBag.message = e;
            }
            return View();
        }
    }
}
