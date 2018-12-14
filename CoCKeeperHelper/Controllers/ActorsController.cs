using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using CoCKeeperHelper.Services;
using CoCKeeperHelper.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CoCKeeperHelper.Controllers
{
    [Route("[controller]")]
    public class ActorsController : Controller
    {
        private IActorsData _actors; 
        public ActorsController(IActorsData actors)
        {
            _actors = actors;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var list = _actors.GetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateIt(ActorsEditModel newCharacter)
        {
            var c = new Character()
            {
                Name = newCharacter.Name,
                //ID = 
            };
            var c1 = _actors.Add(c);

            return View("Index", _actors.GetAll());
        }
    }
}
