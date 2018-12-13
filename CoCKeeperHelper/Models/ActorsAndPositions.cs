using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using Microsoft.AspNetCore.Rewrite.Internal.PatternSegments;

namespace CoCKeeperHelper.Models
{
    // dto
    public class ActorsAndPositions
    {
        public IEnumerable<CharacterPosition> ActorPositions { get; set; }

        public IEnumerable<Character> Actors { get; set; }

        public int Nodes { get; set; }

        public int ActorIdBeingAssignedToNode { get; set; }

        public int NodeActorIsBeingAssignedToo { get; set; }
    }
}
