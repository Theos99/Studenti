using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Monster
{
    public partial class Form1 : Form
    {

        Monster Jesus = new Monster(3300, 420 /* blaze it m8 XDXDXDXDXDXDXDXD */, "Gesù", 10000);  //
        Monster Devil = new Monster(6660, 666, "Satana");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonAttackMns1_Click(object sender, EventArgs e)
        {
            Jesus.damage(Devil);
        }

        private void buttonAttackMns2_Click(object sender, EventArgs e)
        {
            Devil.damage(Jesus);
        }

        private void buttonHealMns1_Click(object sender, EventArgs e)
        {
            Jesus.heal(Jesus);
        }

        private void buttonHealMns2_Click(object sender, EventArgs e)
        {
            Devil.heal(Devil);
        }
    }
}
