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
    public class RequirementsController : Controller
    {
        private readonly corporate1Context _context;
        public corporate1Context db = new corporate1Context();
        public RequirementsController(corporate1Context context)
        {
            _context = context;
        }

        // GET: Requirements
        public IActionResult Index()
        {
            string session = HttpContext.Session.GetString("name");

            if(session == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var data = db.Requirements.FromSql("select * from Requirements");
                return View(data);
            }
            //return View(await _context.Requirements.ToListAsync());
        }

        // GET: Requirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requirement == null)
            {
                return NotFound();
            }

            return View(requirement);
        }

        // GET: Requirements/Create
        public IActionResult AddOrEdit(int id=0)
        {
            return View(new Requirements());
        }

        // POST: Requirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,Departement,Position,NoPosition,Skills,Location,Status,Comments,Date")] Requirements requirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requirement);
        }

        // GET: Requirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements.FindAsync(id);
            if (requirement == null)
            {
                return NotFound();
            }
            return View(requirement);
        }

        // POST: Requirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Edit(int id,Requirements requirement)
        {
            try
            {

                // TODO: Add update logic here

                db.Entry(requirement).State = EntityState.Modified;
                int i = db.SaveChanges();
                if (i == 1)
                {
                    ViewBag.Itemmsg = "Value is Updated";
                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: Requirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requirement == null)
            {
                return NotFound();
            }

            return View(requirement);
        }

        // POST: Requirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requirement = await _context.Requirements.FindAsync(id);
            _context.Requirements.Remove(requirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequirementExists(int id)
        {
            return _context.Requirements.Any(e => e.Id == id);
        }


        [HttpGet]
        public ActionResult Transfer(string Departement)
        {

            return RedirectToAction("Index","SubmissionList");
        }
    }
}
