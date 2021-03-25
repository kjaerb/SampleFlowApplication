using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSampleRepository : ISampleRepository
    {        
        public async Task<ICollection<Sample>> ReadAllSamplesAsync()
        {
            return await Task.Run(() => Sample.stubs()); //Returns all samples
        }
       
        public async Task<ICollection<Sample>> ReadAllSamplesAsync(string teamid)
        {
            return await Task.Run(() => Sample.getSampleByTeamId(teamid, Sample.stubs())); //Returns all samples for a specific team
        }
        
        public async Task<Sample> ReadAsync(string sampleId)
        {
                return await Task.Run(() => Sample.getSampleById(sampleId, Sample.stubs()));       // Return a specific sample 
        }
    }
}