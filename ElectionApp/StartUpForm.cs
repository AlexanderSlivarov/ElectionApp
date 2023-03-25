using System;
using System.Windows.Forms;

namespace ElectionApp
{
    // <summary>
    /// This Form has two buttons. One for the voter and one for the administrator
    /// </summary>
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        // <summary>
        /// This button sends you back to the welcomeForm and hides this form.
        /// </summary>
        private void voteButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }

        // <summary>
        /// This button sends you to the admin page and hides this form.
        /// </summary>
        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminForm = new AdminLogin();
            adminForm.Show();
            this.Hide();
        }
    }
}
