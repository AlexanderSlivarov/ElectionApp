using Business;
using Data.Model;
using System;
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
    // <summary>
    /// This is the ReviewForm. Here the voter can see for which party is he/she has chosen and also the preference number. After that he/she can vote by clicking the button.
    /// </summary>
    public partial class ReviewForm : Form
    {
        // <summary>
        /// Initializing a object from ElectionBusiness type.
        /// </summary>
         
        ElectionBusiness electionBusiness = new ElectionBusiness();
        public ReviewForm()
        {
            InitializeComponent();

            // <summary>
            /// Creating a label for the chosen party and preference number.
            /// </summary>
            Label selectedPartyLabel = new Label();
            selectedPartyLabel.Font = new Font(selectedPartyLabel.Font.FontFamily, 20, FontStyle.Bold);

            if (GlobalVariables.PreferenceNumber == 0)
            {
                selectedPartyLabel.Text = GlobalVariables.SelectedPartyName;
            }
            else
            {
                if (GlobalVariables.SelectedPartyName == "Не подкрепям никого.")
                {
                    selectedPartyLabel.Text = GlobalVariables.SelectedPartyName;
                }
                else
                {
                    selectedPartyLabel.Text = $"{GlobalVariables.SelectedPartyName} \n {GlobalVariables.PreferenceNumber}";
                }                
            }            

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

        // <summary>
        /// This button sends you back to the first page of the Bulletin to change your decision.
        /// </summary>
        private void changeDecisionButton_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }

        // <summary>
        /// This button sends you the settings.
        /// </summary>
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }

        // <summary>
        /// This button generate user's vote and opens the End Form.
        /// </summary>
        private void voteButton_Click(object sender, EventArgs e)
        {
            Party votedParty = null;

            if (GlobalVariables.PreferenceNumber != 0)
            {
                votedParty = new Party(GlobalVariables.SelectedPartyListNumber, GlobalVariables.SelectedPartyName, GlobalVariables.PreferenceNumber);
            }
            else
            {
                votedParty = new Party(GlobalVariables.SelectedPartyListNumber, GlobalVariables.SelectedPartyName);
            }        
            
            votedParty.Votes += 1;

            electionBusiness.Add(votedParty);

            EndForm endForm = new EndForm();
            endForm.Show();
            this.Hide();
        }
    }
}
