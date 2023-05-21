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
            label2.Text = "This is a text based RPG based game! \nYou chose from 4 of the main characters.\nThis game is based on choice and decision making.\nJT Cleary a former pupil of Logan Kelly who has been missing\n since 1963 during the Vietnam War.\nHe has reappeared in Washington DC cybernetically enhanced and improved.\nHe has sent a message to president that war is coming from withing the states.\nThe \"Hope Le Vie\" program has been initiated and the city is in State of Emergency!\nHe plans on becoming the 1st super soldier and building a nation of brainless soldiers!\nHis army has kidnapped children throught the city to complete his army.\n\nTHE WAR HAS BEGUN!";            
        }
    }
}
