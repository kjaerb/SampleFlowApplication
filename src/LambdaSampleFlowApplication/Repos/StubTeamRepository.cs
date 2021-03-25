using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubTeamRepository : ITeamRepository
    {        
        public async Task<ICollection<Team>> ReadAllTeamsAsync()
        {
            return await Task.Run(() => Team.stubs()); //Returns all Teams
        }
        public async Task<Team> ReadAsync(string TeamId)
        {
            return await Task.Run(() => Team.getTeamById(TeamId, Team.stubs()));       // Return a specific Team 
        }
    }
}