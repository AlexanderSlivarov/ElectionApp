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
    public partial class EndForm : Form
    {
        // <summary>
        /// This is the final page that voter can see, thanking for his/her vote.
        /// </summary>
        public EndForm()
        {
            InitializeComponent();
            
            this.Load += new EventHandler(EndForm_Load);
        }

        // <summary>
        /// Here after 3 seconds, the app is closing automatically
        /// </summary>
        private void EndForm_Load(object sender, EventArgs e)
        {
            CloseApp();
        }
        
        private void CloseApp()
        {                     
            Timer timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {            
            Timer timer = (Timer)sender;
            timer.Stop();
            
            Application.ExitThread();
        }
    }
}
