using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieApocalyps
{
    public partial class Battlefield : Form
    {
        public int HumansAmount { get; set; }
        public int humansAmountHelper;
        public int ZombiesAmount { get; set; }
        public int zombiesAmountHelper;
        public int SoldiersAmount { get; set; }
        public int soldiersAmountHelper;
        public int total { get; set; }
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<ToolTip> toolTips = new List<ToolTip>();

        //List<PictureBox> pictureBoxSold = new List<PictureBox>();
        List<Soldier> soldiers = new List<Soldier>();
        //List<PictureBox> pictureBoxHum = new List<PictureBox>();
        List<Human> humans = new List<Human>();
        //List<PictureBox> pictureBoxZomb = new List<PictureBox>();
        List<Zombie> zombies = new List<Zombie>();
        Random rnd = new Random();

        public Battlefield()
        {
            InitializeComponent();
            //List<PictureBox> pictureBoxSold = new List<PictureBox>();
            //List<PictureBox> pictureBoxHum = new List<PictureBox>();
            //List<PictureBox> pictureBoxZomb = new List<PictureBox>();
            //var rnd = new Random();
            //for (int i = 0; i < SoldiersAmount; i++)
            //{
            //    pictureBoxSold[i] = new PictureBox();
            //    pictureBoxSold[i].Image = Properties.Resources.helmet;
            //    pictureBoxSold[i].Location = new Point(rnd.Next(0, 1000), rnd.Next(0, 500));
            //    pictureBoxSold[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxSold[i].Size = new Size(30, 30);
            //    pictureBoxSold[i].SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            //for (int i = 0; i < HumansAmount; i++)
            //{
            //    pictureBoxHum[i] = new PictureBox();
            //    pictureBoxHum[i].Image = global::ZombieApocalyps.Properties.Resources.Human;
            //    pictureBoxHum[i].Location = new System.Drawing.Point(rnd.Next(0, 1000), rnd.Next(0, 500));
            //    pictureBoxHum[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxHum[i].Size = new System.Drawing.Size(30, 30);
            //    pictureBoxHum[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //}
            //for (int i = 0; i < ZombiesAmount; i++)
            //{
            //    pictureBoxZomb[i] = new PictureBox();
            //    pictureBoxZomb[i].Image = global::ZombieApocalyps.Properties.Resources.zombieMap;
            //    pictureBoxZomb[i].Location = new System.Drawing.Point(rnd.Next(0, 1000), rnd.Next(0, 500));
            //    pictureBoxZomb[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxZomb[i].Size = new System.Drawing.Size(30, 30);
            //    pictureBoxZomb[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //}


        }

        private void Battlefield_Load(object sender, EventArgs e)
        {
            total = HumansAmount + ZombiesAmount + SoldiersAmount;
            zombiesAmountHelper = ZombiesAmount;
            humansAmountHelper = HumansAmount;
            soldiersAmountHelper = SoldiersAmount;
            //for (int i = 0; i < SoldiersAmount; i++)
            //{
            //    soldiers.Add(new Soldier());
            //    soldiers[i].money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);
            //    soldiers[i].stamina = rnd.Next(1, 10);
            //}
            //for (int i = 0; i < HumansAmount; i++)
            //{
            //    humans.Add(new Human());
            //    humans[i].Money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);
            //}
            //for (int i = 0; i < ZombiesAmount; i++)
            //{
            //    zombies.Add(new Zombie());
            //    zombies[i].Money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);
            //    zombies[i].Strength = rnd.Next(1, 4);
            //    zombies[i].HumanAgain = rnd.Next(100, 200);
            //}
            for (int i = 0, j = 0; i < total; i++, j++)
            {
                pictureBoxes.Add(new PictureBox());
                if (i < SoldiersAmount)
                {

                    soldiers.Add(new Soldier());
                    soldiers[j].Id = j;
                    soldiers[j].Money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);
                    soldiers[j].Stamina = rnd.Next(7, 15);
                    toolTips.Add(new System.Windows.Forms.ToolTip());

                    pictureBoxes[i].Name = $"Soldier{j}";
                    pictureBoxes[i].Image = Properties.Resources.helmet;
                    pictureBoxes[i].Location = new Point(rnd.Next(0, 731), rnd.Next(0, 351));
                    pictureBoxes[i].Size = new Size(10, 10);
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    toolTips[i].SetToolTip( pictureBoxes[i], $"Id:{soldiers[j].Id}\nMoney:{soldiers[j].Money}\nStamina:{soldiers[j].Stamina}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}");

                    //toolTips[i].Show( $"Id:{soldiers[j].Id}\nMoney:{soldiers[j].Money}\nStamina:{soldiers[j].Stamina}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}", pictureBoxes[i]);
                    //Controls.Add(toolTips[i]);//nie dizała :(
                    this.Controls.Add(pictureBoxes[i]);
                }
                else if (i < SoldiersAmount + HumansAmount)
                {
                    if (i == SoldiersAmount)
                        j = 0;
                    humans.Add(new Human());
                    humans[j].Id = j;
                    humans[j].Money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);

                    toolTips.Add(new System.Windows.Forms.ToolTip());


                    pictureBoxes[i].Name = $"Human{j}";
                    pictureBoxes[i].Image = global::ZombieApocalyps.Properties.Resources.Human;
                    pictureBoxes[i].Location = new System.Drawing.Point(rnd.Next(0, 731), rnd.Next(0, 351));
                    pictureBoxes[i].Size = new System.Drawing.Size(10, 10);
                    pictureBoxes[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    toolTips[i].SetToolTip(pictureBoxes[i], $"Id:{humans[j].Id}\nMoney:{humans[j].Money}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}");
                    this.Controls.Add(pictureBoxes[i]);
                }
                else
                {
                    if (i == SoldiersAmount + HumansAmount)
                    {
                        j = 0;
                    }
                    zombies.Add(new Zombie());
                    zombies[j].Id = j;
                    zombies[j].Money = Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 100)), 2);
                    zombies[j].Strength = rnd.Next(1, 4);
                    zombies[j].HumanAgain = rnd.Next(100, 200);
                    toolTips.Add(new System.Windows.Forms.ToolTip());


                    pictureBoxes[i].Name = $"Zombie{j}";
                    pictureBoxes[i].Image = global::ZombieApocalyps.Properties.Resources.zombieMap;
                    pictureBoxes[i].Location = new System.Drawing.Point(rnd.Next(0, 731), rnd.Next(0, 351));
                    pictureBoxes[i].Size = new System.Drawing.Size(10, 10);
                    pictureBoxes[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    toolTips[i].SetToolTip( pictureBoxes[i], $"Id:{zombies[j].Id}\nMoney:{zombies[j].Money}\nStrength:{zombies[j].Strength}\nHuman Again:{zombies[j].HumanAgain}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}");
                    //toolTips[i].Show($"Id:{zombies[j].Id}\nMoney:{zombies[j].Money}\nStrength:{zombies[j].Strength}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}", pictureBoxes[i]);

                    this.Controls.Add(pictureBoxes[i]);
                }
            }
            //for (int i = 0; i < SoldiersAmount; i++)
            //{


            //    pictureBoxSold.Add(new PictureBox());
            //    pictureBoxSold[i].Image = Properties.Resources.helmet;
            //    pictureBoxSold[i].Location = new Point(rnd.Next(0, 731), rnd.Next(0, 351));
            //    pictureBoxSold[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxSold[i].Size = new Size(10, 10);
            //    pictureBoxSold[i].SizeMode = PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(pictureBoxSold[i]);
            //}
            //for (int i = 0; i < HumansAmount; i++)
            //{


            //    pictureBoxHum.Add(new PictureBox());
            //    pictureBoxHum[i].Image = global::ZombieApocalyps.Properties.Resources.Human;
            //    pictureBoxHum[i].Location = new System.Drawing.Point(rnd.Next(0, 731), rnd.Next(0, 351));
            //    pictureBoxHum[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxHum[i].Size = new System.Drawing.Size(10, 10);
            //    pictureBoxHum[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(pictureBoxHum[i]);
            //}
            //for (int i = 0; i < ZombiesAmount; i++)
            //{


            //    pictureBoxZomb.Add(new PictureBox());
            //    pictureBoxZomb[i].Image = global::ZombieApocalyps.Properties.Resources.zombieMap;
            //    pictureBoxZomb[i].Location = new System.Drawing.Point(rnd.Next(0, 731), rnd.Next(0, 351));
            //    pictureBoxZomb[i].Name = $"PictureBoxSold{i}";
            //    pictureBoxZomb[i].Size = new System.Drawing.Size(10, 10);
            //    pictureBoxZomb[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(pictureBoxZomb[i]);
            //}
        }

        private void Battlefield_moving(object sender, EventArgs e)
        {
            int move;
            for (int i = 0; i < total; i++)
            {
                move = rnd.Next(0, 2);
                if (move == 0 && pictureBoxes[i].Location.Y < 341)
                    pictureBoxes[i].Top += rnd.Next(0, 10);
                else if (move == 1 && pictureBoxes[i].Location.Y > 10)
                    pictureBoxes[i].Top -= rnd.Next(0, 10);
                move = rnd.Next(0, 2);
                if (move == 0 && pictureBoxes[i].Location.X < 721)
                    pictureBoxes[i].Left += rnd.Next(0, 10);
                else if (move == 1 && pictureBoxes[i].Location.X > 10)
                    pictureBoxes[i].Left -= rnd.Next(0, 10);
            }
            //for (int i = 0; i < SoldiersAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxSold[i].Location.Y <341)
            //        pictureBoxSold[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxSold[i].Location.Y >10)
            //        pictureBoxSold[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxSold[i].Location.X < 721)
            //        pictureBoxSold[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxSold[i].Location.X >10)
            //        pictureBoxSold[i].Left -= rnd.Next(0, 10);
            //} 
            //for (int i = 0; i < HumansAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxHum[i].Location.Y < 341)
            //        pictureBoxHum[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxHum[i].Location.Y >10)
            //        pictureBoxHum[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxHum[i].Location.X <721)
            //        pictureBoxHum[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxHum[i].Location.X >10)
            //        pictureBoxHum[i].Left -= rnd.Next(0, 10);
            //} 
            //for (int i = 0; i < ZombiesAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxZomb[i].Location.Y <341)
            //        pictureBoxZomb[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxZomb[i].Location.Y > 10)
            //        pictureBoxZomb[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 &&  pictureBoxZomb[i].Location.X<721)
            //        pictureBoxZomb[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxZomb[i].Location.X > 10)
            //        pictureBoxZomb[i].Left -= rnd.Next(0, 10);
            //}
        }

        private void Battlefield_moving(object sender, KeyEventArgs e)
        {
            int move;
            for (int i = 0; i < total; i++)
            {
                if (pictureBoxes[i].Name.Contains("Human"))
                {
                    for (int j = 0; j < humansAmountHelper; j++)
                    {
                        if ($"Human{humans[j].Id}" == pictureBoxes[i].Name)
                        {
                            if (humans[j].Money>0)
                            {
                                move = rnd.Next(0, 2);
                                if (move == 0 && pictureBoxes[i].Location.Y < 341)
                                    pictureBoxes[i].Top += rnd.Next(0, 10);
                                else if (move == 1 && pictureBoxes[i].Location.Y > 10)
                                    pictureBoxes[i].Top -= rnd.Next(0, 10);
                                move = rnd.Next(0, 2);
                                if (move == 0 && pictureBoxes[i].Location.X < 721)
                                    pictureBoxes[i].Left += rnd.Next(0, 10);
                                else if (move == 1 && pictureBoxes[i].Location.X > 10)
                                    pictureBoxes[i].Left -= rnd.Next(0, 10);
                            }
                        }
                    }
                }
                else
                {
                    move = rnd.Next(0, 2);
                    if (move == 0 && pictureBoxes[i].Location.Y < 341)
                        pictureBoxes[i].Top += rnd.Next(0, 10);
                    else if (move == 1 && pictureBoxes[i].Location.Y > 10)
                        pictureBoxes[i].Top -= rnd.Next(0, 10);
                    move = rnd.Next(0, 2);
                    if (move == 0 && pictureBoxes[i].Location.X < 721)
                        pictureBoxes[i].Left += rnd.Next(0, 10);
                    else if (move == 1 && pictureBoxes[i].Location.X > 10)
                        pictureBoxes[i].Left -= rnd.Next(0, 10);
                }
       
              
               
            }
            //for (int i = 0; i < SoldiersAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxSold[i].Location.Y < 341)
            //        pictureBoxSold[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxSold[i].Location.Y > 10)
            //        pictureBoxSold[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxSold[i].Location.X < 721)
            //        pictureBoxSold[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxSold[i].Location.X > 10)
            //        pictureBoxSold[i].Left -= rnd.Next(0, 10);
            //}
            //for (int i = 0; i < HumansAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxHum[i].Location.Y < 341)
            //        pictureBoxHum[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxHum[i].Location.Y > 10)
            //        pictureBoxHum[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxHum[i].Location.X < 721)
            //        pictureBoxHum[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxHum[i].Location.X > 10)
            //        pictureBoxHum[i].Left -= rnd.Next(0, 10);
            //}
            //for (int i = 0; i < ZombiesAmount; i++)
            //{
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxZomb[i].Location.Y < 341)
            //        pictureBoxZomb[i].Top += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxZomb[i].Location.Y > 10)
            //        pictureBoxZomb[i].Top -= rnd.Next(0, 10);
            //    move = rnd.Next(0, 2);
            //    if (move == 0 && pictureBoxZomb[i].Location.X < 721)
            //        pictureBoxZomb[i].Left += rnd.Next(0, 10);
            //    else if (move == 1 && pictureBoxZomb[i].Location.X > 10)
            //        pictureBoxZomb[i].Left -= rnd.Next(0, 10);
            //}

            //zombie zamieniający się w człowieka 
            for (int j = 0; j < zombiesAmountHelper; j++)
            {
                if (zombies.Count == 0)
                {
                    break;
                }
                zombies[j].HumanAgain -= 1;
                if (zombies[j].HumanAgain == 0)
                {
                    for (int i = 0; i < total; i++)
                    {
                        if (pictureBoxes[i].Name == $"Zombie{zombies[j].Id}")
                        {
                            humans.Add(new Human());
                            humans[humansAmountHelper].Id = HumansAmount;
                            humans[humansAmountHelper].Money = zombies[j].Money;
                            pictureBoxes[i].Name = $"Human{HumansAmount}";
                            pictureBoxes[i].Image = Properties.Resources.Human;
                            toolTips[i].SetToolTip(pictureBoxes[i], $"Id:{humans[humansAmountHelper].Id}\nMoney:{humans[humansAmountHelper].Money}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}");

                            zombies.Remove(zombies[j]);
                            HumansAmount++;
                            humansAmountHelper++;

                            zombiesAmountHelper--;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < total; i++)
                    {
                        if (pictureBoxes[i].Name == $"Zombie{zombies[j].Id}")
                        {

                            toolTips[i].SetToolTip(pictureBoxes[i], $"Id:{zombies[j].Id}\nMoney:{zombies[j].Money}\nStrength:{zombies[j].Strength}\nHuman again:{zombies[j].HumanAgain}\nX:{pictureBoxes[i].Location.X}\nY:{pictureBoxes[i].Location.Y}");

                            break;
                        }
                    }
                }
            }

            //spotkanie zombie - człowiek
            bool done;
            for (int i = 0; i < humansAmountHelper; i++)
            {
                done = false;
                for (int j = 0; j < total; j++)
                {
                    if ($"Human{humans[i].Id}" == pictureBoxes[j].Name)
                    {
                        for (int k = 0; k < total; k++)
                        {
                            if (pictureBoxes[k].Name.Contains("Zombie") && (Math.Abs(pictureBoxes[j].Left - pictureBoxes[k].Left) < 10 && Math.Abs(pictureBoxes[j].Top - pictureBoxes[k].Top) < 10))
                            {
                                zombies.Add(new Zombie());
                                zombies[zombiesAmountHelper].Id = ZombiesAmount;
                                zombies[zombiesAmountHelper].Money =  humans[i].Money - Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 10)), 2);
                                zombies[zombiesAmountHelper].Strength = rnd.Next(1, 4);
                                zombies[zombiesAmountHelper].HumanAgain = rnd.Next(200, 300);

                                pictureBoxes[j].Name = $"Zombie{ZombiesAmount}";
                                pictureBoxes[j].Image = Properties.Resources.zombieMap;
                                toolTips[j].SetToolTip(pictureBoxes[j], $"Id:{zombies[zombiesAmountHelper].Id}\nMoney:{zombies[zombiesAmountHelper].Money}\nStrength:{zombies[zombiesAmountHelper].Strength}\nHuman again:{zombies[zombiesAmountHelper].HumanAgain}\nX:{pictureBoxes[j].Location.X}\nY:{pictureBoxes[j].Location.Y}");

                                humans.Remove(humans[i]);
                                ZombiesAmount++;
                                zombiesAmountHelper++;

                                humansAmountHelper--;
                                done = true;

                                break;
                            }
                            done = true;

                        }
                    }
                    if (done == true)
                    {
                        break;
                    }
                }

            }


            //spotkanie żołenierz - człowiek
            for (int i = 0; i < humansAmountHelper; i++)
            {
                done = false;
                for (int j = 0; j < total; j++)
                {
                    if ($"Human{humans[i].Id}" == pictureBoxes[j].Name)
                    {
                        for (int k = 0; k < total; k++)
                        {
                            if (pictureBoxes[k].Name.Contains("Soldier") && (Math.Abs(pictureBoxes[j].Left - pictureBoxes[k].Left) < 10 && Math.Abs(pictureBoxes[j].Top - pictureBoxes[k].Top) < 10))
                            {
                                if (10 > humans[i].Money)
                                {
                                    soldiers.Add(new Soldier());
                                    soldiers[soldiersAmountHelper].Id = SoldiersAmount;
                                    soldiers[soldiersAmountHelper].Money =humans[i].Money+ Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 10)), 2);
                                    soldiers[soldiersAmountHelper].Stamina = rnd.Next(2, 7);

                                    pictureBoxes[j].Name = $"Soldier{SoldiersAmount}";
                                    pictureBoxes[j].Image = Properties.Resources.helmet;
                                    toolTips[j].SetToolTip(pictureBoxes[j], $"Id:{soldiers[soldiersAmountHelper].Id}\nMoney:{soldiers[soldiersAmountHelper].Money}\nStamina:{soldiers[soldiersAmountHelper].Stamina}\nX:{pictureBoxes[j].Location.X}\nY:{pictureBoxes[j].Location.Y}");

                                    humans.Remove(humans[i]);
                                    SoldiersAmount++;
                                    soldiersAmountHelper++;

                                    humansAmountHelper--;
                                    done = true;
                                    break;
                                }
                                else
                                {
                                    humans[i].Money -= 10;
                                    toolTips[j].SetToolTip(pictureBoxes[j], $"Id:{humans[i].Id}\nMoney:{humans[i].Money}\nX:{pictureBoxes[j].Location.X}\nY:{pictureBoxes[j].Location.Y}");

                                }

                            }
                            done = true;

                        }
                    }
                    if (done == true)
                    {
                        break;
                    }
                }
            }


            //spotkanie żołenierz - zombie
            bool done2 = false ;
            for (int i = 0; i < soldiersAmountHelper; i++)
            {
                done = false;
                for (int j = 0; j < total; j++)
                {
                    if ($"Soldier{soldiers[i].Id}" == pictureBoxes[j].Name)
                    {
                        for (int k = 0; k < total; k++)
                        {
                            if (pictureBoxes[k].Name.Contains("Zombie") && (Math.Abs(pictureBoxes[j].Left - pictureBoxes[k].Left) < 10 && Math.Abs(pictureBoxes[j].Top - pictureBoxes[k].Top) < 10))
                            {
                                for (int l = 0; l < zombiesAmountHelper; l++)
                                {
                                    if ($"Zombie{zombies[l].Id}" == pictureBoxes[k].Name)
                                    {
                                        if (zombies[l].Strength > soldiers[i].Stamina)
                                        {
                                            zombies.Add(new Zombie());
                                            zombies[zombiesAmountHelper].Id = ZombiesAmount;
                                            zombies[zombiesAmountHelper].Money = soldiers[i].Money > 10 ? soldiers[i].Money - Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 10)), 2) : soldiers[i].Money;
                                            zombies[zombiesAmountHelper].Strength = rnd.Next(2, 6);
                                            zombies[zombiesAmountHelper].HumanAgain = rnd.Next(150, 250);

                                            pictureBoxes[j].Name = $"Zombie{ZombiesAmount}";
                                            pictureBoxes[j].Image = Properties.Resources.zombieMap;
                                            toolTips[j].SetToolTip(pictureBoxes[j], $"Id:{zombies[zombiesAmountHelper].Id}\nMoney:{zombies[zombiesAmountHelper].Money}\nStrength:{zombies[zombiesAmountHelper].Strength}\nHuman again:{zombies[zombiesAmountHelper].HumanAgain}\nX:{pictureBoxes[j].Location.X}\nY:{pictureBoxes[j].Location.Y}");
                                            
                                            soldiers.Remove(soldiers[i]);
                                            ZombiesAmount++;
                                            zombiesAmountHelper++;

                                            done2 = true;
                                            soldiersAmountHelper--;
                                            break;
                                        }
                                        else
                                        {
                                            soldiers[i].Stamina -= zombies[l].Strength;
                                            humans.Add(new Human());
                                            humans[humansAmountHelper].Id = HumansAmount;
                                            humans[humansAmountHelper].Money = zombies[l].Money + Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 50)), 2);

                                            pictureBoxes[k].Name = $"Human{HumansAmount}";
                                            pictureBoxes[k].Image = Properties.Resources.Human;
                                            toolTips[k].SetToolTip(pictureBoxes[k], $"Id:{humans[humansAmountHelper].Id}\nMoney:{humans[humansAmountHelper].Money}\nX:{pictureBoxes[k].Location.X}\nY:{pictureBoxes[k].Location.Y}");
                                            toolTips[j].SetToolTip(pictureBoxes[j], $"Id:{soldiers[i].Id}\nMoney:{soldiers[i].Money}\nStamina:{soldiers[i].Stamina}\nX:{pictureBoxes[j].Location.X}\nY:{pictureBoxes[j].Location.Y}");

                                            zombies.Remove(zombies[l]);
                                            HumansAmount++;
                                            humansAmountHelper++;

                                            zombiesAmountHelper--;
                                            break;
                                        }

                                    }

                                }

                            }
                            done = true;
                            if (done2==true)
                            {
                                done2 = false;
                                break;
                            }

                        }
                    }
                    if (done == true)
                    {
                        break;
                    }
                }

            }
            //for (int i = 0; i < ZombiesAmount; i++)
            //{
            //    zombies[i].HumanAgain -= 1;
            //    if (zombies[i].HumanAgain == 0)
            //    {
            //        humans.Add(new Human());
            //        humans.Last().Money = zombies[i].Money + Math.Round((rnd.NextDouble() * (double)rnd.Next(0, 50)), 2); ;
            //        zombies.Remove(zombies[i]);
            //        ZombiesAmount--;
            //        HumansAmount++;

            //        pictureBoxZomb[i].Image = global::ZombieApocalyps.Properties.Resources.Human;

            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Form1();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
