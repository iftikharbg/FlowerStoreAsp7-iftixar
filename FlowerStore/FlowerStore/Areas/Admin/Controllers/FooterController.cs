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
    public class FooterController : Controller
    {
        private AppDbContext _context;

        public FooterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Footer _footer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var footer = _context.Footers.FirstOrDefault();

            footer.Logo = Request.Form["Logo"];
            footer.FacebookUrl = Request.Form["FacebookUrl"];
            footer.LinkedinUrl = Request.Form["LinkedinUrl"];
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
