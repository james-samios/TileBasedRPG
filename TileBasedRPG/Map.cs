using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedRPG
{
    class Map
    {
        Tile[,] tiles = new Tile[15, 15];

        public Tile[,] LoadMap()
        {
            // main map - building levels coming after.
            string[] lines = System.IO.File.ReadAllLines(@"../../map.txt");

            foreach (string line in lines)
            {

                string[] tmp = line.Split('|');
                Tile newTile = new Tile();
                newTile.x = int.Parse(tmp[0]);
                newTile.y = int.Parse(tmp[1]);
                newTile.floor = tmp[2];
                newTile.canpass = bool.Parse(tmp[3]);
                newTile.special = tmp[4];

                tiles[newTile.x, newTile.y] = newTile;

            }

            return tiles;

        }

        public string getEvent(int x, int y)
        {
            return tiles[x, y].special;
        }

        public string getFloor(int x, int y)
        {
            return tiles[x, y].floor;
        }

        public bool canPass(int x, int y)
        {
            return tiles[x, y].canpass;
        }

        public string GetTile(string floor)
        {
            string returntile = "";

            if (floor == "Grass")
            {
                returntile = "Grass";
            }
            else if (floor == "GreyFloor")
            {
                returntile = "GreyFloor";
            }
            else if (floor == "Forest")
            {
                returntile = "Forest";
            }
            else if (floor == "Lava")
            {
                returntile = "Lava";
            }
            else if (floor == "GreyWall")
            {
                returntile = "GreyWall";
            }
            else if (floor == "MetalDoor")
            {
                returntile = "MetalDoor1";
            }
            else if (floor == "Wood")
            {
                returntile = "Wood";
            }
            else if (floor == "RedFloor")
            {
                returntile = "RedFloor";
            }
            else if (floor == "RedWall")
            {
                returntile = "RedWall";
            }
            else if (floor == "Water")
            {
                returntile = "Water";
            }
            else if (floor == "Chest")
            {
                returntile = "Chest1";
            }
            else if (floor == "Monster")
            {
                string[] monsters = new string[3];
                monsters[0] = "Ghost";
                monsters[1] = "Slime";
                monsters[2] = "Skeleton";
                Random rand = new Random();

                returntile = (monsters[rand.Next(0,3)]);
            }
            else
            {
                returntile = "Forest";
            }

            return returntile;
        }

    }
}