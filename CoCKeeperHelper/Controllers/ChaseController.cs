using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using CoCKeeperHelper.Models;
using CoCKeeperHelper.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoCKeeperHelper.Controllers
{

    [Route("[controller]")]
    public class ChaseController : Controller
    {
        private int nodes = 6;

        private IActorPositionsData _actorPositions;
        private IActorsData _actorsData;

        public ChaseController(IActorPositionsData actorPositionsData, IActorsData actorsData)
        {
            _actorPositions = actorPositionsData;
            _actorsData = actorsData;
        }

        [Route("index")]
        public IActionResult Index()
        {
            /*var cp = _actorPositions.GetAll();

            //ViewBag.Name =
            ViewData["Nodes"] = nodes;*/

            var cp = new ActorsAndPositions();

            cp.Nodes = nodes;

            cp.ActorPositions = new List<CharacterPosition>();
            cp.Actors = new List<Character>();

            cp.ActorPositions = _actorPositions.GetAll();
            cp.Actors = _actorsData.GetAll();
            // return new ObjectResult(cp);
            return View(cp);
        }

        [Route("path")]
        public IActionResult Path()
        {
            ChasePath cp = new ChasePath();

            return new ObjectResult(cp);
        }

        //[HttpPost]
        [Route("Assign")]
        public IActionResult Assign(ActorsAndPositions aandp)
        {
            var positionToChange = _actorPositions.GetAll()
                .FirstOrDefault(x => x.CharacterID == aandp.ActorIdBeingAssignedToNode);

            if (positionToChange == null)
            {
                positionToChange = new CharacterPosition() {CharacterID = aandp.ActorIdBeingAssignedToNode};
                _actorPositions.Add(positionToChange);
            }

            positionToChange.Position = aandp.NodeActorIsBeingAssignedToo;

            aandp.Nodes = nodes;

            aandp.ActorPositions = new List<CharacterPosition>();
            aandp.Actors = new List<Character>();

            aandp.ActorPositions = _actorPositions.GetAll();
            aandp.Actors = _actorsData.GetAll();

            return View("Index", aandp);
        }

        /*public string Test()
        {
            return "Chase";
        }*/
    }
}