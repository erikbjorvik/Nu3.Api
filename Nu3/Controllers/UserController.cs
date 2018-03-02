using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nu3.Models;
using Nu3.Services.Interfaces;

namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Produces("application/json")]
        [HttpPost]
        public IActionResult AddUser()
        {
            try
            {
                _userService.AddUser(null);
                return Ok();
            }
            catch (Exception exception)
            {
                return Json(exception.Message);
            }
            
        }
    }
}