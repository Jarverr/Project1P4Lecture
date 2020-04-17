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
    public partial class Form1 : Form
    {
        public int HumansAmount { get; set; }
        public int ZombiesAmount { get; set; }
        public int SoldiersAmount { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tempNumb;
            Int32.TryParse(textBoxHuman.Text, out tempNumb);
            HumansAmount = tempNumb;
            Int32.TryParse(textBoxSoldier.Text, out tempNumb);
            SoldiersAmount = tempNumb;
            Int32.TryParse(textBoxZombie.Text, out tempNumb);
            ZombiesAmount = tempNumb;
            this.Hide();
            var battlefield = new Battlefield();
            battlefield.Closed += (s, args) => this.Close();
            battlefield.HumansAmount = HumansAmount;
            battlefield.ZombiesAmount = ZombiesAmount;
            battlefield.SoldiersAmount = SoldiersAmount;
            battlefield.Show();
          
        }
    }
}
