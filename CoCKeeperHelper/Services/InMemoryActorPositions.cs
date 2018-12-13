using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using Microsoft.AspNetCore.JsonPatch.Internal;

namespace CoCKeeperHelper.Services
{
    public class InMemoryActorPositions : IActorPositionsData
    {
        private List<CharacterPosition> _actorPositions;

        public InMemoryActorPositions()
        {
            _actorPositions = new List<CharacterPosition>();
            var character1 = new CharacterPosition() { CharacterID = 1, Position = 0, ID = 1};
            _actorPositions.Add(character1);

            var character2 = new CharacterPosition() { CharacterID = 2, Position = 3 , ID = 2};
            _actorPositions.Add(character2);
        }

        public CharacterPosition Add(CharacterPosition pos)
        {
            pos.ID = _actorPositions.Max(r => r.ID) + 1;
            _actorPositions.Add(pos);
            return pos;
        }

        public IEnumerable<CharacterPosition> GetAll()
        {
            return _actorPositions;
        }
    }
}
