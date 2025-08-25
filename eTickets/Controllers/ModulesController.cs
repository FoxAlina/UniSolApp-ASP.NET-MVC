using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data;
using UniversalSolutionApplication.Data.Services;
using UniversalSolutionApplication.Models;

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
            var data = await service.GetAllAsync();

            return View(data);
        }

        //Get: Module/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, Name, Description")] Module _module)
        {
            _module.init();

            if (!ModelState.IsValid)
            {
                return View(_module);
            }

            await service.AddAsync(_module);
            return RedirectToAction(nameof(Index));
        }

        //Get: Module/Details/Module1
        public async Task<IActionResult> Details(Guid _id)
        {
            var module = await service.GetByIdAsync(_id);

            if (module == null) return View("NotFound");

            return View(module);
        }

        //Get: Module/Edit
        public async Task<IActionResult> Edit(Guid _id)
        {
            var module = await service.GetByIdAsync(_id);

            if (module == null) return View("NotFound");

            return View(module);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid _id, [Bind("Id, ProfilePictureURL, Name, Description")] Module _module)
        {
            if (!ModelState.IsValid)
            {
                return View(_module);
            }

            await service.UpdateAsync(_id, _module);
            return RedirectToAction(nameof(Index));
        }
    }
}
