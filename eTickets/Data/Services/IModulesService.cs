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
        Task<Module> GetByIdAsync(Guid id);
        Task AddAsync(Module module);
        Task<Module> UpdateAsync(Module newModule);
        void Delete(Guid id);

        Task<User> GetUser();
    }
}
