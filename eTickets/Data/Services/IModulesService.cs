using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Models;

namespace UniversalSolutionApplication.Data.Services
{
    public interface IModulesService
    {
        Task<IEnumerable<Module>> GetAll();
        Module GetById(string _id);
        void Add(Module _module);
        Module Update(string _id, Module _newModule);
        void Delete(string _id);

    }
}
