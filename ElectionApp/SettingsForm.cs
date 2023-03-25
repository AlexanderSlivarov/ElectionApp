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
    /// This is the SettingsForm. Here you can adjust your UI's brightness, text font, text size and theme
    /// </summary>
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();           
        }

        // <summary>
        /// This button sends you to the first page of the Bulletin and hides this form.
        /// </summary>
        private void returnBackButton_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }

        // <summary>
        /// This is the horrizontal ScrollBar which changes the percentage of the Brightness
        /// </summary>
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int maxVal = hScrollBar.Maximum - hScrollBar.LargeChange + 1;
            int percent = (int)(((double)hScrollBar.Value / (double)maxVal) * 100.0);
            
            percentageLabel.Text = percent.ToString() + "%";
        }
    }
}
