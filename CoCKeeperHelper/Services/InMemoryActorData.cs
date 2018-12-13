using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoCKeeperHelper.Services
{
    public class InMemoryActorData : IActorsData
    {
        //todo rename charactor to actor as they can be pc's or npc's
        private List<Character> _actors;

        public InMemoryActorData()
        {
            _actors = new List<Character>();

            var a1 = new Character()
            {
                Name = "Farmer",
                ID = 1
            };
            _actors.Add(a1);

            var a2 = new Character()
            {
                Name = "Harvey",
                ID = 2
            };
            _actors.Add(a2);
        }

        public Character Add(Character actor)
        {
            actor.ID = _actors.Max(r => r.ID) + 1;
            _actors.Add(actor);
            return actor;
        }

        public IEnumerable<Character> GetAll()
        {
            return _actors;
        }

        public List<SelectListItem> SelectList()
        {
            var list = new List<SelectListItem>();

            /*foreach (var i in _actors)
            {            
                list.Add(new SelectListItem { Value = i.ID.ToString(), Text = i.Name };);
            }*/

            return list;
        }
    }
}
