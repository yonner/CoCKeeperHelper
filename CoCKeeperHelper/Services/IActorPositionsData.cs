using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;

namespace CoCKeeperHelper.Services
{
    public interface IActorPositionsData
    {
        IEnumerable<CharacterPosition> GetAll();

        CharacterPosition Add(CharacterPosition pos);
    }
}
