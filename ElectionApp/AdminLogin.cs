using System;
using System.Windows.Forms;

namespace ElectionApp
{
    // <summary>
    /// This is the admin login page
    /// </summary>
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
        }

        // <summary>
        /// This methods checks if the person who is login is an admin
        /// </summary>
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (passwordTextBox.Text == "1")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {                    
                    passwordLabel.Text = "Грешна парола.";
                }
            }
        }

        // <summary>
        /// This button sends you back to the StartUp page and hides this form.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            StartUpForm startUpForm = new StartUpForm();
            startUpForm.Show();
            this.Hide();
        }
    }
}
