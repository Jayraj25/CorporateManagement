using System;
using System.Collections.Generic;
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataFile filesave, Candidate candidate, IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                    filesave.Path = "No File Exist";

                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot" + "/Files/", Path.GetFileName(file.FileName));
                    file.CopyTo(new FileStream(path, FileMode.Create));
                    // var stream = new FileStream(path, FileMode.Create);
                    filesave.Path = "/" + Path.GetFileName(file.FileName);
                    filesave.Extension = Path.GetExtension(file.FileName);
                    candidate.Resumes = Path.GetFileName(file.FileName);
                }
            }
            catch (Exception e)
            {
                ViewBag.message = e;
            }
            db.Candidate.Add(candidate);
            db.DataFile.Add(filesave);
            ViewData["Result"] = db.SaveChanges();

            return RedirectToAction("Index","Candidates");

            /*if (ModelState.IsValid)
            {
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);*/
        }
    }
}
