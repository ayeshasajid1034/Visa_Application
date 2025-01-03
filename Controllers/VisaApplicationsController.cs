// /Controllers/VisaApplicationsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisaApplicationManager.Data;
using VisaApplicationManager.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace VisaApplicationManager.Controllers
{
    public class VisaApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisaApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.VisaApplications.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,PassportCopyFile,VisaType,CountryOfApplication,ApplicationStatus")] VisaApplication visaApplication)
        {
            if (ModelState.IsValid)
            {
                if (visaApplication.PassportCopyFile != null && visaApplication.PassportCopyFile.Length > 0)
                {
                    var fileName = Path.GetFileName(visaApplication.PassportCopyFile.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await visaApplication.PassportCopyFile.CopyToAsync(stream);
                    }
                    visaApplication.PassportCopyPath = filePath;
                }

                _context.Add(visaApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visaApplication);
        }
    }
}
