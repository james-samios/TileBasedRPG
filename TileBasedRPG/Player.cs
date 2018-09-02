using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedRPG
{
    class Player
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }

        public int health { get; set; }
        public int strength { get; set; }
        public int ability { get; set; }
        public int armour { get; set; }
        public int speed { get; set; }
        public int defence { get; set; }
    }
}
