﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_w7
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                PictureBox gmbr = new PictureBox();
                gmbr.Image = listgmbr.Images[i];
                gmbr.Location = new Point(12 * i, 12);
                this.Controls.Add(gmbr);
            }
        }
    }
}
