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

            int top = 60;

            for (int i = 0; i < 13; i++)
            {
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Font = new Font(checkBoxes[i].Font.FontFamily, 14f);
                checkBoxes[i].Text = names[i];
                checkBoxes[i].Left = 10;
                checkBoxes[i].Top = top;
                this.Controls.Add(checkBoxes[i]);
                top += 30;
            }
        }
    }
}
