using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileBasedRPG
{
    public partial class Form1 : Form
    {
        static int mapsize = 15;
        int boxsize = 30;
        Map map = new Map();
        Player player = new Player();
        PictureBox[,] picmap = new PictureBox[mapsize, mapsize];
        int health = 100;
        int ability = 1;


        public Form1()
        {
            InitializeComponent();
            this.KeyPress += Form1_KeyPress;
            abilityBar.ForeColor = Color.LightSeaGreen;
            abilityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            healthBar.ForeColor = Color.Green;
            healthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'a')
            {
                movePlayer(-1, 0);
            }
            else if (e.KeyChar == 'd')
            {
                movePlayer(1, 0);
            }
            else if (e.KeyChar == 'w')
            {
                movePlayer(0, -1);
            }
            else if (e.KeyChar == 's')
            {
                movePlayer(0, 1);
            }

        }

        private void movePlayer(int x, int y)
        {
            // check for bounds of map
            // check for canpass in map tiles
            if (player.x + x >= 0 && player.x + x < mapsize
                && player.y + y >= 0 && player.y + y < mapsize
                && map.canPass(player.x + x, player.y + y))
            {
                // rewrite image to map
                picmap[player.x, player.y].Image = Image.FromFile(@"../../Tiles/" + map.GetTile(map.getFloor(player.x, player.y)) + ".png");

                // change player x and y
                player.x += x;
                player.y += y;

                // write image of player to map + tile for backdrop
                picmap[player.x, player.y].Image = Image.FromFile(@"../../Tiles/Player.png");
                picmap[player.x, player.y].BackgroundImage = Image.FromFile(@"../../Tiles/" + map.GetTile(map.getFloor(player.x, player.y)) + ".png");

                //debugstuff();

                checkEvent();

            }

        }

        private void checkEvent()
        {
            string chest = "You found ITEM!";
            if (map.getEvent(player.x, player.y) == "Monster")
            {
                MessageBox.Show(player.warcry);
            }
            else if (map.getEvent(player.x, player.y) == "Chest")
            {
                MessageBox.Show(chest);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupMap();
            setupPlayer();
            //debugstuff();
        }

        private void setupPlayer()
        {
            player.warcry = "Cry havoc and let slip the dogs of war!";
            player.x = 8;
            player.y = 5;
            player.name = "Steve";
            picmap[player.x, player.y].Image = Image.FromFile(@"../../Tiles/Player.png");
            picmap[player.x, player.y].BackgroundImage = Image.FromFile(@"../../Tiles/" + map.GetTile(map.getFloor(player.x, player.y)) + ".png");
        }

        private void setupMap()
        {

            Tile[,] tiles = map.LoadMap();

            foreach (Tile t in map.LoadMap())
            {
                Console.WriteLine(t.x + " | " + t.y + " | " + t.floor.PadRight(12) + " | " + t.canpass.ToString());

                PictureBox pic = new PictureBox();
                pic.Location = new Point((t.x * boxsize) + 10, (t.y * boxsize) + 10);
                pic.Size = new Size(boxsize, boxsize);

                pic.Image = Image.FromFile(@"../../Tiles/" + map.GetTile(t.floor) + ".png");
                Controls.Add(pic);
                picmap[t.x, t.y] = pic;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void debugstuff()
        {
            stripX.Text = player.x.ToString();
            stripY.Text = player.y.ToString();
            stripFloor.Text = map.getFloor(player.x, player.y);
        } */

        private void stripFloor_Click(object sender, EventArgs e)
        {

        }

        private void abilityBar_Click(object sender, EventArgs e)
        {

        }
    }
}
