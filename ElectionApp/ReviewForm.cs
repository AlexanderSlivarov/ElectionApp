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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();

            Label selectedPartyLabel = new Label();
            selectedPartyLabel.Font = new Font(selectedPartyLabel.Font.FontFamily, 17, FontStyle.Bold);
            selectedPartyLabel.Text = $"{GlobalVariables.SelectedPartyName} \n {GlobalVariables.PreferenceNumber}";

            selectedPartyLabel.AutoSize = false;
            selectedPartyLabel.TextAlign = ContentAlignment.MiddleCenter;
            selectedPartyLabel.Dock = DockStyle.Fill;
                     
            this.Controls.Add(selectedPartyLabel);

            if (GlobalVariables.SelectedPartyName is null)
            {
                selectedPartyLabel.Visible = false;
            }
            else
            {
                selectedPartyLabel.Visible = true;
            }                                    
        }       

        private void changeDecisionButton_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }
    }
}
