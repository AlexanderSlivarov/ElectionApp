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
    /// This Form welcomes the voter for the 49-th elections for Bulgarian parliament.
    /// </summary>
    public partial class WelcomeForm : Form
    {
        
        public WelcomeForm()
        {
            InitializeComponent();
        }

        // <summary>
        /// This button sends you to the first page of the Bulletin and hides this form.
        /// </summary>
        private void voteButton_Click(object sender, EventArgs e)
        {
            BulletinForm1 bulletinForm1 = new BulletinForm1();
            bulletinForm1.Show();
            this.Hide();
        }
    }
}
