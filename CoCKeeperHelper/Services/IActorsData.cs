using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoCKeeperHelper.Services
{
    public interface IActorsData
    {
        IEnumerable<Character> GetAll();

        Character Add(Character actor);
        List<SelectListItem> SelectList();
    }
}
