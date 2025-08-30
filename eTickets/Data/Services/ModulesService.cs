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
        private readonly AppDbContext _context;

        public ModulesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Module module)
        {
            await _context.Modules.AddAsync(module);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _context.Modules.FirstOrDefaultAsync(n => n.Id == id);
            _context.Modules.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Module>> GetAllAsync()
        {
            return await _context.Modules.ToListAsync();
        }

        public async Task<Module> GetByIdAsync(Guid id)
        {
            return await _context.Modules.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Module> UpdateAsync(Module newModule)
        {
            var dbModule = await _context.Modules.FirstOrDefaultAsync(n => n.Id == newModule.Id);

            if (dbModule != null)
            {
                dbModule.fillAllFromModule(newModule);
                await _context.SaveChangesAsync();
            }

            //_context.Update(newModule);
            //await _context.SaveChangesAsync();
            return newModule;
        }

        public async Task<User> GetUser()
        {
            return await _context.Users.FirstOrDefaultAsync();
        }
    }
}
