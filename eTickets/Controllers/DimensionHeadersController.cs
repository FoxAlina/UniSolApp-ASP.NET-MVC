using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data;

namespace UniversalSolutionApplication.Controllers
{
    public class DimensionHeadersController : Controller
    {
        private readonly AppDbContext context;

        public DimensionHeadersController(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await context.DimensionHeaders.ToListAsync();

            return View();
        }
    }
}
