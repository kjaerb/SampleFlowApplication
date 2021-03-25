using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface ISecurityDepRepository
    {
        Task<ICollection<SecurityDepartment>> ReadAllSecurityDepsAsync();
        Task<SecurityDepartment> ReadAsync(string securityDepid);
    }
}