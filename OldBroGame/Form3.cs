using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldBroGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 titlePG = new Form2();
            this.Hide();
            titlePG.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {            
            label2.Text = "This is a text based RPG based game, with 4 main characters.\nYou chose your character and your path will be decided from there.\nThe city has been put on a state of emergency after the multiple bombing attacks.\nRandom assasinations and attemps on varios officials\n in office has put the city on high alert.\nThe team has gathered information about who this could possibly be!\nUnfortunatley all possible leads are going back towards three main suspects.\nThe first two suspects are off the grid\n and the third is leaving a trail specifically for you to follow.\nYou must uncover as much information that you can to find out who they are!\nYou can choose to follow the trail being left behind\n or you can chose another route to uncover the truth. ";

        }
    }
}
