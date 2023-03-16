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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            BulletinForm bulletinForm = new BulletinForm();
            bulletinForm.Show();
            this.Hide();
        }
    }
}
