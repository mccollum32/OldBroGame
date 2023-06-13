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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Form2 homeScreen = new Form2();
            this.Hide();
            homeScreen.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Dutch Plissken";
            const int AGE = 56;
            label1.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[0];
            label2.Text = ($"{name} : Born in the UK.\nDutch learned through various fights growing up he was a talented street fighter.\nHe later joined in the British Army.\nBecomming a decorated soldier during the Cold War with the \"15th Infantry Brigade\".\nDutch mastered his craft with weapononry also as a spotter.\nHis specialty is sniping, short/mid/long range weapons.");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Logan Kelly";
            const int AGE = 44;
            label1.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[1];
            label2.Text = ($"{name} : Born in Alaska.\nFormer US Marine of the \"1st Marine Regiment\".\nLogan has a natural sense for the hunt and battle.\nAn outcast since the death of his parents at the young age of 10.\nLogan went under the wing of his grandfather and has been trained to survive.\nAnd survival is what he knows best.\nHis specialty is Close quaters combat, long distance, hand crafted weapons and demoltions.");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Sergei Kozlov";
            const int AGE = 36;
            label1.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[2];
            label2.Text = ($"{name} : Born in Moscow, Russia.\nSergei was predetermined to be a soldier of fortune.\nBeing part of the Cold War Sergei only knows how to survive.\nWith a his part in \"Operation Ryan\".\nSergei was part of the team that shot down KAL-007.\nHis specialty is mid/long distance weapons, hand to hand combat and steet smarts. ");

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Misty X";
            const int AGE = 23;
            label1.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[3];
            label2.Text = ($"{name} : Born in Parts Unknown.\nMisty's childhood is cloudy from her last full memory of waking up in a labratory\nunder the name known as \"Project 3x\".\nSergei saved her and a few other lost children from the labratoy.\nTrying to gain what little she has from her lost memory\nShe searches for clues about her life.\nUnder the wing of Sergei, Misty hones in on her skills\nto help save the lost children.");

        }

        private void contBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Character Selected:\nDutch Plissken");
                Form5 startGame = new Form5();
                this.Hide();
                startGame.Show();
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Character Selected:\nLogan Kelly");
                Form5 startGame = new Form5();
                this.Hide();
                startGame.Show();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Character Selected:\nSergei Kozlov");
                Form5 startGame = new Form5();
                this.Hide();
                startGame.Show();
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Character Selected:\nMisty X");
                Form5 startGame = new Form5();
                this.Hide();
                startGame.Show();
            }     
        }
    }
}
