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
        //private readonly corporate1Context _context;
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



        /*public AssignCandidateController(corporate1Context context)
        {
            _context = context;
        }

        // GET: AssignCandidate
        public async Task<IActionResult> Index()
        {
            return View(await _context.Candidate.ToListAsync());
        }

        // GET: AssignCandidate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // GET: AssignCandidate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AssignCandidate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Firstname,Middlename,Lastname,Jobtitle,Email,Cell,Home,Fax,Address1,Address2,City,Zip,Departement,Country,Hire,Comptetenices,Jobcategory,Source,Resumeupload,Resumes,Status,Feedback")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: AssignCandidate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return View(candidate);
        }

        // POST: AssignCandidate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Firstname,Middlename,Lastname,Jobtitle,Email,Cell,Home,Fax,Address1,Address2,City,Zip,Departement,Country,Hire,Comptetenices,Jobcategory,Source,Resumeupload,Resumes,Status,Feedback")] Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: AssignCandidate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: AssignCandidate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidate = await _context.Candidate.FindAsync(id);
            _context.Candidate.Remove(candidate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidate.Any(e => e.Id == id);
        }*/
    }
}
