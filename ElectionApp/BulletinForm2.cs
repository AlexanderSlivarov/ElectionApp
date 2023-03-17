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
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Font = new Font(checkBoxes[i].Font.FontFamily, 15);
                checkBoxes[i].AutoSize = true;

                if (i == 8)
                {
                    checkBoxes[i].Text = names[i];
                }
                else
                {
                    checkBoxes[i].Text = $"{i + 1}. {names[i]}";
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

                    int index = i * 3 + j + 101;
                    RadioButton rb = new RadioButton();
                    rb.Font = new Font(rb.Font.FontFamily, 15);
                    rb.AutoSize = true;
                    rb.Text = index.ToString();
                    rb.Name = "radioButton" + index.ToString();
                    rb.Left = x + j * 100;
                    rb.Top = y + i * 40;
                    this.Controls.Add(rb);
                }
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SingleCheck((CheckBox)sender);
        }
        private void SingleCheck(CheckBox checkedBox)
        {
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb != checkedBox)
                {
                    cb.Checked = false;
                }
            }
        }
        private void previousPage_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }
    }
}
