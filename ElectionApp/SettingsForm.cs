﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void returnBackButton_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }
    }
}