using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repos;

namespace WebApiNovo.Controllers
{
    [ApiController]
    [Route("api/SecurityDeps")]
    public class SecurityDepWebController : ControllerBase
    {
        private readonly ISecurityDepRepository _SecurityDepRepository;
        public SecurityDepWebController(ISecurityDepRepository SecurityDepRepository)
        {
            _SecurityDepRepository = SecurityDepRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<SecurityDepartment>> GetAll()
        {
            return await _SecurityDepRepository.ReadAllSecurityDepsAsync();
        }        

        [HttpGet("{id}")]
        public async Task<SecurityDepartment> GetSecurityDepbyId(String id)
        {
            return await _SecurityDepRepository.ReadAsync(id);
        }
    }
}
