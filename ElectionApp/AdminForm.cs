using Business;
using Data.Model;
using System;
using System.Collections;
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
            electionResultsGrid.ReadOnly = true;
            electionResultsGrid.Dock = DockStyle.Fill;            

            foreach (DataGridViewColumn column in electionResultsGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            electionResultsGrid.Columns[0].Visible = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Party party in electionBusiness.GetAll())
            {
                electionBusiness.Delete(party.ID);
            }

            electionResultsGrid.Visible = false;
        }
    }
}
