using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSecurityDepRepository : ISecurityDepRepository
    {        
        public async Task<ICollection<SecurityDepartment>> ReadAllSecurityDepsAsync()
        {
            return await Task.Run(() => SecurityDepartment.stubs()); //Returns all SecurityDeps
        }
        public async Task<SecurityDepartment> ReadAsync(string securityDepId)
        {
                return await Task.Run(() => SecurityDepartment.getSecurityDepByName(securityDepId, SecurityDepartment.stubs()));       // Return a specific SecurityDep 
        }
    }
}