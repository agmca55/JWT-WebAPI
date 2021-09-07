using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_WebAPI.Services;
using JWT_WebAPI.Models;
//branch 1 changes
namespace JWT_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {          
        private IAuthenticateService _authenticateService;
        private IAuthenticateService _tempBranch1; //change 1 branch 1
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
            ///hhhhhhhh
        }
        public IActionResult Post([FromBody]User model)
        {
            var user = _authenticateService.Authenticate(model.UserName, model.Password);
            if (user == null) return BadRequest(new {message="Username or password is incorrect"});
            return Ok(user); 
        }

        //branch 1 new update
        public IActionResult Put([FromBody]User model)
        {
            return Ok(model);
        }
    }
}
