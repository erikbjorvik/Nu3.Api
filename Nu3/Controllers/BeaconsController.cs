using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nu3.Controllers
{
    [Produces("application/json")]
    [Route("api/beacons")]
    public class BeaconsController : Controller
    {
        [Produces("application/json")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Json("test");
        }

    }
}