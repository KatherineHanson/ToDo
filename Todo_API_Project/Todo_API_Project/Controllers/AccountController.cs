using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Todo_API_Project.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "http://localhost:5000/signin-github")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

    }
}