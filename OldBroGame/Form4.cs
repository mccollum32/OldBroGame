﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Image bgImage = Properties.Resources.zeldaBG;

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bgImage, 0, 0);
        }
    }
}
