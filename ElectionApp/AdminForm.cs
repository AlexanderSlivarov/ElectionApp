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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (passwordTextBox.Text == "12345")
                {
                    passwordLabel.Visible = false;
                    passwordTextBox.Visible = false;
                }
                else
                {                    
                    passwordLabel.Text = "Грешна парола.";
                }
            }
        }
    }
}
