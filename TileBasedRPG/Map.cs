using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedRPG
{
    class Map
    {
        Tile[,] tiles = new Tile[5, 5];

        public Tile[,] LoadMap()
        {
            string[] lines = System.IO.File.ReadAllLines(@"map.txt");

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

        public string GetColor(string floor)
        {
            string returncolor = "";

            if (floor == "Grass")
            {
                returncolor = "Green";
            }
            else if (floor == "Mountain")
            {
                returncolor = "DarkSlateGray";
            }
            else if (floor == "Forest")
            {
                returncolor = "DarkGreen";
            }
            else if (floor == "Lava")
            {
                returncolor = "Red";
            }
            else if (floor == "Coffee")
            {
                returncolor = "SaddleBrown";
            }
            else if (floor == "Cafe")
            {
                returncolor = "DarkKhaki";
            }
            else if (floor == "Banananana")
            {
                returncolor = "DarkGoldenrod";
            }
            else
            {
                returncolor = "Fuchsia";
            }

            return returncolor;
        }

    }
}