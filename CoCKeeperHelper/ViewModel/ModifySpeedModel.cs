using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCKeeperHelper.Models
{

    public enum PassType
    {
        Regular = 0,
        Hard,
        Extreme,
        Fail
    }

    public class ModifySpeedModel
    {
        public int ChaserMov { get; set; }
        public int EscapeeMov { get; set; }

        public PassType EscapeeRoll { get; set; }

        public PassType ChaserRoll { get; set; }
    }
}
