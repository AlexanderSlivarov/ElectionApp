using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        Dictionary<string, int> partyVotes = new Dictionary<string, int>();
        DataGridView summedVotesGrid = new DataGridView();
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
            electionResultsGrid.Columns[3].Visible = false;
        }
        private void sumButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in electionResultsGrid.Rows)
            {
                string partyName = row.Cells["ListNumber"].Value.ToString() + " - " + row.Cells["Name"].Value.ToString() + " - " + row.Cells["Votes"].Value.ToString();

                if (partyVotes.ContainsKey(partyName))
                {
                    partyVotes[partyName]++;
                }
                else
                {
                    partyVotes.Add(partyName, 1);
                }
            }

            DataTable summedVotesTable = new DataTable();
            summedVotesTable.Columns.Add("ListNumber", typeof(int));
            summedVotesTable.Columns.Add("Party", typeof(string));
            summedVotesTable.Columns.Add("Votes", typeof(int));

            foreach (KeyValuePair<string, int> kvp in partyVotes)
            {
                string[] partyInfo = kvp.Key.Split('-');
                int listNumber = int.Parse(partyInfo[0]);
                string partyName = partyInfo[1].Trim();
                int voteCount = kvp.Value;
                summedVotesTable.Rows.Add(listNumber, partyName, voteCount);
            }

            summedVotesGrid.DataSource = summedVotesTable;
            summedVotesGrid.Dock = DockStyle.Fill;

            foreach (DataGridViewColumn column in summedVotesGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            electionResultsGrid.Visible = false;
            Controls.Add(summedVotesGrid);
            sumButton.Visible = false;
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Party party in electionBusiness.GetAll())
            {
                electionBusiness.Delete(party.ID);
            }

            Application.ExitThread();
        }
    }
}