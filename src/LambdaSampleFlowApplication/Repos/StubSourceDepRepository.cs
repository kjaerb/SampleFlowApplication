using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSourceDepRepository : ISourceDepRepository
    {
        public async Task<ICollection<SourceDepartment>> ReadAllSourceDepsAsync() 
        {
            return await Task.Run(() => SourceDepartment.stubs()); //Returns all Source Deps
        }
        public async Task<SourceDepartment> ReadAsync(string sourceDepId)
        {
            return await Task.Run(() => SourceDepartment.getSourceDepartmentById(sourceDepId,SourceDepartment.stubs())); // Return a specific Source Dep     
        }
    }
}