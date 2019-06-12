using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using summer19.Model;

namespace summer19.Controllers
{
    public class FileController : Controller
    {
        public corporate1Context db = new corporate1Context();
        private readonly corporate1Context _context;

        public FileController(corporate1Context context)
        {
            _context = context;
        }

       
        public IActionResult File()
        {
            ViewBag.message = db.DataFile.ToList();
            return View();
        }

    }
}
