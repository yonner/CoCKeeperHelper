using CoCKeeperHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCKeeperHelper.Controllers
{
    [Route("[controller]")]
    public class SpeedController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var cs = new ChaseSpeeds();

            return View(cs);
        }

        [Route("Assign")]
        public IActionResult Assign(ChaseSpeeds cs)
        {
            var mod = new ModifySpeedModel()
            {
                ChaserMov = cs.ChaserMov,
                EscapeeMov = cs.EscapeeMov
            };
            return View("ModifySpeed", mod);
        }
    }
}
