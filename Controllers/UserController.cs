using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
 
namespace portfolio.Controllers
{
    public class UserController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult   Index()
        {
            
            return View("home");
        }
        [HttpGetAttribute]
        [Route("projects")]
        public IActionResult   Project()
        {
            
            return View("projects");
        }
        [HttpGetAttribute]
        [Route("contact")]
        public IActionResult   Contact()
        {
            
            return View("contacts");
        }
    }
}