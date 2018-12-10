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
        private int nodes = 6; 


        [Route("index")]
        public IActionResult Index()
        {
            CharacterPositions cp = new CharacterPositions();

            //ViewBag.Name =
            ViewData["Nodes"] = nodes;

            // return new ObjectResult(cp);
            return View(cp);
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