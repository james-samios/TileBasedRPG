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
        static int mapsize = 5;
        int boxsize = 30;
        Map map = new Map();
        Player player = new Player();
        PictureBox[,] picmap = new PictureBox[mapsize, mapsize];


        public Form1()
        {
            InitializeComponent();
            this.KeyPress += Form1_KeyPress;
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
                // rewrite color to map
                picmap[player.x, player.y].BackColor = Color.FromName(map.GetColor(map.getFloor(player.x, player.y)));

                // change player x and y
                player.x += x;
                player.y += y;

                // write color of player to map
                picmap[player.x, player.y].BackColor = Color.Azure;

                //debugstuff();

                checkEvent();

            }

        }

        private void checkEvent()
        {
            if (map.getEvent(player.x, player.y) == "Monster")
            {
                MessageBox.Show(player.warcry);
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
            player.x = 0;
            player.y = 0;
            player.name = "Steve";
            picmap[player.x, player.y].BackColor = Color.Beige;
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

                pic.BackColor = Color.FromName(map.GetColor(t.floor));

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
    }
}
