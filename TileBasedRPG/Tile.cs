using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedRPG
{
    class Tile
    {
        public int x { get; set; }
        public int y { get; set; }
        public string floor { get; set; }
        public bool canpass { get; set; }
        public string special { get; set; }
    }
}
