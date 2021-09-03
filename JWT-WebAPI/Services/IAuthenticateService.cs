using JWT_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_WebAPI.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string username, string password);
    }
}
