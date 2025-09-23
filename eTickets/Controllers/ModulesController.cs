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
        private readonly IModulesService _service;

        public ModulesController(IModulesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        //Get: Module/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, Name, Description")] Module module)
        {
            module.init();
            User user = await _service.GetUser();
            module.UserId = user.Id;

            if (!ModelState.IsValid)
            {
                return View(module);
            }

            await _service.AddAsync(module);
            return RedirectToAction(nameof(Index));
        }

        //Get: Module/Details/Module1
        public async Task<IActionResult> Details(Guid id)
        {
            var module = await _service.GetByIdAsync(id);

            if (module == null) return View("NotFound");

            return View(module);
        }

        //Get: Module/Edit/Module1
        public async Task<IActionResult> Edit(Guid id)
        {
            var module = await _service.GetByIdAsync(id);

            if (module == null) return View("NotFound");

            return View(module);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Module module)
        {
            if (!ModelState.IsValid)
            {
                return View(module);
            }

            await _service.UpdateAsync(module);
            return RedirectToAction(nameof(Details), new { id = module.Id });
        }

        //Get: Module/Delete/Module1
        public async Task<IActionResult> Delete(Guid id)
        {
            var module = await _service.GetByIdAsync(id);

            if (module == null) return View("NotFound");

            return View(module);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var module = await _service.GetByIdAsync(id);

            if (module == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
