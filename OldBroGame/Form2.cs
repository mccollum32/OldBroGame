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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            logoLabel.Parent = pictureBox1;
        }


        private void startButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1 character = new Form1();
            this.Hide();
            character.Show();
        }

        private void quitButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 gameDesription = new Form3();
            this.Hide();
            gameDesription.Show();
        }

    }
}
