using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface ISourceDepRepository
    {
        Task<ICollection<SourceDepartment>> ReadAllSourceDepsAsync();
        Task<SourceDepartment> ReadAsync(string sourceDepId);
    }
}