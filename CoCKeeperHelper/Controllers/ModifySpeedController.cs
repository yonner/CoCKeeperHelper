using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCKeeperHelper.Controllers
{
    public class ModifySpeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Modify")]
        public IActionResult Modify(ModifySpeedModel msm)
        {

            return View("");
        }
    }
}