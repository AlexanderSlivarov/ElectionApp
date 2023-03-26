using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElectionApp
{
    // <summary>
    /// This is the second page of the Bulletin with the remained parties.
    /// </summary>
    public partial class BulletinForm2 : Form
    {
        CheckBox[] checkBoxes = new CheckBox[9];

        string[] names = {
            "\"Левицата!\"",
            "\"Български възход\"",
            "\"МИР\"",
            "\"Българска социалдемокрация - Евролевица\"",
            "\"Български съюз за директна демокрация - БСДД\"",
            "\"Глас Народен\"",
            "\"Социалистическа партия Български път\"",
            "\"Вън от ЕС и НАТО\"",
            "Не подкрепям никого." };

        public BulletinForm2()
        {
            InitializeComponent();

            int top = 100;

            for (int i = 0; i < 9; i++)
            {
                // <summary>
                /// Creating checkBoxes for each party.
                /// </summary>
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Font = new Font(checkBoxes[i].Font.FontFamily, 15);
                checkBoxes[i].AutoSize = true;

                if (i == 8)
                {
                    checkBoxes[i].Text = names[i];
                }
                else
                {
                    checkBoxes[i].Text = $"{i + 14}. {names[i]}";
                }
                
                checkBoxes[i].Left = 10;
                checkBoxes[i].Top = top;
                this.Controls.Add(checkBoxes[i]);
                top += 40;
            }

            foreach (CheckBox cb in checkBoxes)
            {
                cb.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            }

            int x = 650;
            int y = 150;

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 10 && j == 2)
                    {
                        break;
                    }

                    // <summary>
                    /// Creating radioButtons for preference number.
                    /// </summary>
                    int index = i * 3 + j + 101;
                    RadioButton radioButton = new RadioButton();
                    radioButton.Font = new Font(radioButton.Font.FontFamily, 15);
                    radioButton.AutoSize = true;
                    radioButton.Text = index.ToString();
                    radioButton.Name = "radioButton" + index.ToString();
                    radioButton.Left = x + j * 100;
                    radioButton.Top = y + i * 40;
                    this.Controls.Add(radioButton);

                    radioButton.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
                }
            }
        }

        // <summary>
        /// This method traces the checkBoxes to be selected only one of them.
        /// </summary>
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = (CheckBox)sender;

            if (checkedBox.Checked)
            {
                try
                {
                    GlobalVariables.SelectedPartyListNumber = int.Parse(checkedBox.Text.Substring(0, 1));
                    GlobalVariables.SelectedPartyName = checkedBox.Text.Substring(3);
                }
                catch (FormatException)
                {
                    GlobalVariables.SelectedPartyName = checkedBox.Text;
                }
                

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox != checkedBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        // <summary>
        /// This method keeps the preference number when it is selected
        /// </summary>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                GlobalVariables.PreferenceNumber = int.Parse(radioButton.Text);
            }
        }

        // <summary>
        /// This button sends you to the first page of the Bulletin and hides this form.
        /// </summary>
        private void previousPage_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }

        // <summary>
        /// This button sends you to the review page and hides this form.
        /// </summary>
        private void reviewButton_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();
            this.Hide();
        }

        // <summary>
        /// This button sends you to settings page and hides this form.
        /// </summary>
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }
    }
}
