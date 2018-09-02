using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedRPG
{
    class Item
    {
        public string ReturnItem()
        {
            string[] lines = File.ReadAllLines(@"../../items.txt"); 
            Random rand = new Random();
            return lines[rand.Next(lines.Length)];
        }

    }
}
