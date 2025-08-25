using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Models;

namespace UniversalSolutionApplication.Data.Services
{
    public interface IModulesService
    {
        Task<IEnumerable<Module>> GetAllAsync();
        Task<Module> GetByIdAsync(Guid _id);
        Task AddAsync(Module _module);
        Task<Module> UpdateAsync(Guid _id, Module _newModule);
        void Delete(Guid _id);

    }
}
