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
        Item item = new Item();


        public Form1()
        {
            InitializeComponent();
            this.KeyPress += Form1_KeyPress;
            abilityBar.ForeColor = Color.LightSeaGreen;
            abilityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            healthBar.ForeColor = Color.Green;
            healthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            strengthBar.ForeColor = Color.Crimson;
            strengthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            armourBar.ForeColor = Color.Blue;
            armourBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            defenceBar.ForeColor = Color.Goldenrod;
            defenceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            speedBar.ForeColor = Color.MediumOrchid;
            speedBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            if (map.getEvent(player.x, player.y) == "Monster")
            {
                startBattle();
            }
            else if (map.getEvent(player.x, player.y) == "Chest")
            {
                openChest();
            }
        }

        public void startBattle()
        {

        }

        public void openChest()
        {
            // name|armour|strength|defence|speed
            bool hasArmour = false;
            bool hasWeapon = false;
            bool hasShield = false;

            string getItem = item.ReturnItem();
            string[] list = getItem.Split('|');
            string type = list[0];
            string name = list[1];
            int armour = int.Parse(list[2]);
            int strength = int.Parse(list[3]);
            int defence = int.Parse(list[4]);
            int speed = int.Parse(list[5]);

            string maxArmour = "You couldn't possibly carry any more armour or you'll break your back!\n\nYou won't get the armour for this item!";
            string maxStrength = "The strength of this item exceeds your physical ability to hold. You aren't the Hulk!\n\nYou won't get the strength for this item!";
            string maxSpeed = "Whoa, you're fast enough, you won't be given the speed from this item!";
            string maxDefence = "You are well enough prepared for a defence, therefore, you won't be given the defence for this item!";

            if (type == "armour") {
                if (name == "DemonBreastplate")
                {
                    MessageBox.Show("You have found a Demon Breastplate. This gives you:\n" + armour + " Armour points");
                    armourLabel.Text = "Armour: Demon Breastplate";
                    if (player.armour + armour >= 100)
                    {
                        MessageBox.Show(maxArmour);
                    }
                    else
                    {
                        player.armour += armour;
                        setupBars();
                    }
                }
                else if (name == "BattleplateofAncientPower")
                {
                    MessageBox.Show("You have found a Battleplate of Ancient Power. This gives you:\n" + armour + " Armour points");
                    armourLabel.Text = "Armour: Battleplate of Ancient Power";
                    if (player.armour + armour >= 100)
                    {
                        MessageBox.Show(maxArmour);
                    }
                    else
                    {
                        player.armour += armour;
                        setupBars();
                    }
                }
                else if (name == "SinisterLeatherVest")
                {
                    MessageBox.Show("You have found a Sinister Leather Vest. This gives you:\n" + armour + " Armour points");
                    armourLabel.Text = "Armour: Sinister Leather Vest";
                    if (player.armour + armour >= 100)
                    {
                        MessageBox.Show(maxArmour);
                    }
                    else
                    {
                        player.armour += armour;
                        setupBars();
                    }
                }
                else if (name == "ProtectorofCarnage")
                {
                    MessageBox.Show("You have found a Protector of Carnage. This gives you:\n" + armour + " Armour points");
                    armourLabel.Text = "Armour: Protector of Carnage";
                    if (player.armour + armour >= 100)
                    {
                        MessageBox.Show(maxArmour);
                    }
                    else
                    {
                        player.armour += armour;
                        setupBars();
                    }
                }
            } else if (type == "shield")
            {
                if (name == "KingsDefender")
                {
                    MessageBox.Show("You have found a Kings Defender Shield. This gives you:\n" + defence + " Defence points");
                    shieldLabel.Text = "Shield: Kings Defender";
                    if (player.defence + defence >= 100)
                    {
                        MessageBox.Show(maxDefence);
                    }
                    else
                    {
                        player.defence += defence;
                        setupBars();
                    }
                }
                else if (name == "Glacier")
                {
                    MessageBox.Show("You have found a Glacier Shield. This gives you:\n" + defence + " Defence points");
                    shieldLabel.Text = "Shield: Glacier";
                    if (player.defence + defence >= 100)
                    {
                        MessageBox.Show(maxDefence);
                    }
                    else
                    {
                        player.defence += defence;
                        setupBars();
                    }
                }
                else if (name == "DefenderOakWall")
                {
                    MessageBox.Show("You have found a Defender Oak Wall Shield. This gives you:\n" + defence + " Defence points");
                    shieldLabel.Text = "Shield: Defender Oak Wall";
                    if (player.defence + defence >= 100)
                    {
                        MessageBox.Show(maxDefence);
                    }
                    else
                    {
                        player.defence += defence;
                        setupBars();
                    }
                }
                else if (name == "JadeInfusedOakGreatshield")
                {
                    MessageBox.Show("You have found a Jade Infused Oak Great Shield. This gives you:\n" + defence + " Defence points");
                    shieldLabel.Text = "Shield: Jade Infused Oak Great Shield";
                    if (player.defence + defence >= 100)
                    {
                        MessageBox.Show(maxDefence);
                    }
                    else
                    {
                        player.defence += defence;
                        setupBars();
                    }
                }
            }
            else if (type == "sword")
            {
                if (name == "Worldslayer")
                {
                    MessageBox.Show("You have found a Worldslayer Sword. This gives you:\n" + strength + " Strength points");
                    shieldLabel.Text = "Sword: Worldslayer";
                    if (player.strength + strength >= 100)
                    {
                        MessageBox.Show(maxStrength);
                    }
                    else
                    {
                        player.strength += strength;
                        setupBars();
                    }
                }
                else if (name == "Oathbreaker")
                {
                    MessageBox.Show("You have found a Oathbreaker Sword. This gives you:\n" + strength + " Strength points");
                    shieldLabel.Text = "Sword: Oathbreaker";
                    if (player.strength + strength >= 100)
                    {
                        MessageBox.Show(maxStrength);
                    }
                    else
                    {
                        player.strength += strength;
                        setupBars();
                    }
                }
                else if (name == "SteelReaver")
                {
                    MessageBox.Show("You have found a Steel Reaver Sword. This gives you:\n" + strength + " Strength points");
                    shieldLabel.Text = "Sword: Steel Reaver";
                    if (player.strength + strength >= 100)
                    {
                        MessageBox.Show(maxStrength);
                    }
                    else
                    {
                        player.strength += strength;
                        setupBars();
                    }
                }
                else if (name == "SkewerOfCorruption")
                {
                    MessageBox.Show("You have found a Skewer Of Corruption. This gives you:\n" + strength + " Strength points");
                    shieldLabel.Text = "Sword: Skewer of Corruption";
                    if (player.strength + strength >= 100)
                    {
                        MessageBox.Show(maxStrength);
                    }
                    else
                    {
                        player.strength += strength;
                        setupBars();
                        // would setup chest disappear but didn't have time.
                    }
                }
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
            player.health = 100;
            player.strength = 0;
            player.ability = 1;
            player.defence = 0;
            player.speed = 0;
            player.armour = 0;
            player.x = 8;
            player.y = 5;
            player.name = "Phil";
            picmap[player.x, player.y].Image = Image.FromFile(@"../../Tiles/Player.png");
            picmap[player.x, player.y].BackgroundImage = Image.FromFile(@"../../Tiles/" + map.GetTile(map.getFloor(player.x, player.y)) + ".png");
            setupBars();
        }

        public void setupBars()
        {
            healthBar.Value = player.health;
            armourBar.Value = player.armour;
            abilityBar.Value = player.ability;
            defenceBar.Value = player.defence;
            speedBar.Value = player.speed;
            strengthBar.Value = player.strength;
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

        private void healthBar_Click(object sender, EventArgs e)
        {

        }

        private void healthLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
