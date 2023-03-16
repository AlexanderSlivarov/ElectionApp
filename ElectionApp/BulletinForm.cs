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
    public partial class BulletinForm : Form
    {
        CheckBox[] checkBoxes = new CheckBox[13];

        string[] names = new string[] {
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
        public BulletinForm()
        {
            InitializeComponent();

            int top = 100;

            for (int i = 0; i < 13; i++)
            {
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Font = new Font(checkBoxes[i].Font.FontFamily, 15);
                checkBoxes[i].AutoSize = true;
                checkBoxes[i].Text = names[i];
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
                    rb.Font = new Font(checkBoxes[i].Font.FontFamily, 15);
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
    }
}
