using CoCKeeperHelper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCKeeperHelper.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            CharacterPositions cp = new CharacterPositions();

            return "Hello from the home controller!";
        }
    }
}
