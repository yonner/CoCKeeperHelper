using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoCKeeperHelper.Controllers
{
    [Route("[controller]")]
    public class ChaseController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            CharacterPositions cp = new CharacterPositions();

            // return new ObjectResult(cp);
            return View();
        }

        [Route("path")]
        public IActionResult Path()
        {
            ChasePath cp = new ChasePath();

            return new ObjectResult(cp);
        }

        /*public string Test()
        {
            return "Chase";
        }*/
    }
}