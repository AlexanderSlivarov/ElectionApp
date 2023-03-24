using Business;
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
        ElectionBusiness electionBusiness = new ElectionBusiness();
        public AdminForm()
        {
            InitializeComponent();

            electionResultsGrid.DataSource = electionBusiness.GetAll();            
            electionResultsGrid.Dock = DockStyle.Fill;

            foreach (DataGridViewColumn column in electionResultsGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
