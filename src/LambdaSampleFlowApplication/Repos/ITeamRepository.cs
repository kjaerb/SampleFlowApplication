using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface ITeamRepository
    {
        Task<ICollection<Team>> ReadAllTeamsAsync();
        Task<Team> ReadAsync(String Teamid);
    }
} 