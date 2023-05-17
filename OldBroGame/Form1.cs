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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 titlePage = new Form2();
            this.Hide();
            titlePage.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Dutch Plissken";
            const int AGE = 56;
            label2.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[0];
            label4.Text = ($"{name} : Born in Wales, UK.\nDutch learned through various fights growing up he was a talented street fighter.\nHe tried to turn his life over and enter professional boxing but certain mishaps happen.\nIllegal street boxing rings and arms dealing lead him behind bars.\nSince his release from prison Dutch turned a new leaf and chose to justify his wrongdoings.\nHis specialty is boxinb/grappling/submissions short/mid/long range weapons.");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Logan Kelly";
            const int AGE = 44;
            label2.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[1];
            label4.Text = ($"{name} : Born in Alaska. \nLogan has a natural sense for the hunt and battle.\nAn outcast since the death of his parents at the age of 10 by a wild wolf pack.\nLogan went under the wing of his grandfather and has been trained to survive.\nAnd survival is what he knows best.\nHis specialty is Close quaters combat, long distance, hand crafted weapons and demoltions.");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Sergei Kozlov";
            const int AGE = 36;
            label2.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[2];
            label4.Text = ($"{name} : Born in Moscow, Russia. \nInfluenced by his older now deceased brother to join a life of crime in his younger years.\nHe knows his ways around organized crime as well as the justice system.\nSergei has turned his life around and fights against the wrongs\n that he felt in his heart he committed even if he had no ties to it.\nHis specialty is mid/long distance weapons, hand to hand combat and steet smarts. ");

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Misty X";
            const int AGE = 23;
            label2.Text = ($"{name} , Age: {AGE}");
            pictureBox1.Image = imageList1.Images[3];
            label4.Text = ($"{name} : Born in Parts Unknown. \nMisty's childhood is cloudy from her last full memory of waking up in a labratory.\nTrying to gain what little she has from her lost memory\n she notices that she is very skilled in all forms of combat and survival.\nSergei saves her and a few other lost children from the labratoy.\nShe joins with the OldBros to find out who she really is!\nAnd to stop terror in the city and save all that she can!");
        }
    }
}
