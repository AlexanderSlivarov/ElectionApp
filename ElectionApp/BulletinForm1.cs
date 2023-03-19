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
    public partial class BulletinForm1 : Form
    {
        CheckBox[] checkBoxes = new CheckBox[13];
        RadioButton[] radioButtons = new RadioButton[32];

        private Label partyLabel;        

        private string[] names = new string[] {
            "БСП",
            "ГЕРБ-СДС",
            "\"Възраждане\"",
            "\"Има такъв народ\"",
            "\"Народна партия Истината и само истината\"",
            "\"Неутрална България\"",
            "\"Българско национално обединение\"",
            "\"Заедно\"",
            "\"Български национален съюз\"",
             "НДСВ",
            "\"КОД\"",
            "\"Продължаваме промяната - Демократична България\"",
            "ДПС" };
        public BulletinForm1()
        {
            InitializeComponent();

            int top = 100;

            for (int i = 0; i < 13; i++)
            {
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Font = new Font(checkBoxes[i].Font.FontFamily, 15);
                checkBoxes[i].AutoSize = true;
                checkBoxes[i].Text = $"{i + 1}. {names[i]}";
                checkBoxes[i].Left = 10;
                checkBoxes[i].Top = top;
                this.Controls.Add(checkBoxes[i]);
                top += 40;
            }

            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
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
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = (CheckBox)sender;

            if (checkedBox.Checked)
            {
                GlobalVariables.SelectedPartyID = int.Parse(checkedBox.Text.Substring(0, 1));
                GlobalVariables.SelectedPartyName = checkedBox.Text.Substring(3);

                foreach (CheckBox cb in checkBoxes)
                {
                    if (cb != checkedBox)
                    {
                        cb.Checked = false;
                    }
                }                                                            
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                GlobalVariables.PreferenceNumber = int.Parse(radioButton.Text);
            }
        }
        private void nextPage_Click(object sender, EventArgs e)
        {
            BulletinForm2 bulletinForm2 = new BulletinForm2();
            bulletinForm2.Show();
            this.Hide();            
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();
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
