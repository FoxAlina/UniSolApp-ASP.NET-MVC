using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Models;

namespace UniversalSolutionApplication.Data.Services
{
    public class ModulesService : IModulesService
    {
        private readonly AppDbContext context;

        public ModulesService(AppDbContext _context)
        {
            context = _context;
        }

        public async Task AddAsync(Module _module)
        {
            await context.Modules.AddAsync(_module);
            await context.SaveChangesAsync();
        }

        public void Delete(Guid _id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Module>> GetAllAsync()
        {
            return await context.Modules.ToListAsync();
        }

        public async Task<Module> GetByIdAsync(Guid _id)
        {
            return await context.Modules.FirstOrDefaultAsync(n => n.Id == _id);
        }

        public async Task<Module> UpdateAsync(Guid _id, Module _newModule)
        {
            context.Update(_newModule);
            await context.SaveChangesAsync();
            return _newModule;
        }
    }
}
