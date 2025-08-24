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

        public void Add(Module _module)
        {
            context.Modules.Add(_module);
            context.SaveChanges();
        }

        public void Delete(string _id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Module>> GetAll()
        {
            return await context.Modules.ToListAsync();
        }

        public Module GetById(string _id)
        {
            throw new NotImplementedException();
        }

        public Module Update(string _id, Module _newModule)
        {
            throw new NotImplementedException();
        }
    }
}
