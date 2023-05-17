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
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Form1 character = new Form1();
            this.Hide();
            character.Show();
        }

        private void descriptionBtn_Click(object sender, EventArgs e)
        {
            Form3 gameDesription = new Form3();
            this.Hide();
            gameDesription.Show();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            this.Hide();
            menu.Show();
        }
    }
}
