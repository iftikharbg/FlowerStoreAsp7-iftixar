using FlowerStore.DAL;
using FlowerStore.Migrations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeaderController : Controller
    {
        private AppDbContext _context;

        public HeaderController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Header _header)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var header = _context.Headers.FirstOrDefault();

            header.Logo = Request.Form["Logo"];
           await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
