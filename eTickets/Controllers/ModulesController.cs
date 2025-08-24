using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data;
using UniversalSolutionApplication.Data.Services;

namespace UniversalSolutionApplication.Controllers
{
    public class ModulesController : Controller
    {
        private readonly IModulesService service;

        public ModulesController(IModulesService _service)
        {
            service = _service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await service.GetAll();

            return View(data);
        }

    }
}
