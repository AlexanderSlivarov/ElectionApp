using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace ElectionApp
{
    // <summary>
    /// This is the Admin page where you can see the results of the election.
    /// </summary>
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

            summedVotesGrid.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            summedVotesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            foreach (DataGridViewColumn column in electionResultsGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            electionResultsGrid.Columns[0].Visible = false;
            electionResultsGrid.Columns[3].Visible = false;
        }

        // <summary>
        /// This button summarize the results.
        /// </summary>
        private void sumButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<int>> partyPreferences = new Dictionary<string, List<int>>();
            foreach (DataGridViewRow row in electionResultsGrid.Rows)
            {
                string partyName = row.Cells["ListNumber"].Value.ToString() + " : " + row.Cells["Name"].Value.ToString() + " : " + row.Cells["Votes"].Value.ToString();
                int[] prefNums = Array.ConvertAll(row.Cells["PreferenceNumber"].Value.ToString().Split(','), s => int.Parse(s.Trim()));

                if (partyPreferences.ContainsKey(partyName))
                {
                    partyPreferences[partyName].AddRange(prefNums.ToList());
                }
                else
                {
                    partyPreferences.Add(partyName, prefNums.ToList());
                }

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
            summedVotesTable.Columns.Add("Preferences", typeof(string));

            var sortedParties = partyVotes.OrderByDescending(x => x.Value);

            foreach (var party in sortedParties)
            {
                string[] partyInfo = party.Key.Split(':');
                int listNumber = int.Parse(partyInfo[0]);
                string partyName = partyInfo[1].Trim();
                int voteCount = party.Value;
                List<int> preferences = partyPreferences[party.Key];
                string preferencesString = string.Join(",", preferences.Select(p => p.ToString()));
                summedVotesTable.Rows.Add(listNumber, partyName, voteCount, preferencesString);
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

        // <summary>
        /// This button resets the vote results and force app to exit.
        /// </summary>
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