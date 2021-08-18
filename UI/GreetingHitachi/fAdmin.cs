using GreetingHitachi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void tpAccounts_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            string queryAccounts = "exec USP_GetAccountList ";
            DataTable dataTable = dataProvider.ExecuteQuery(queryAccounts);
            dtgvAccounts.DataSource = dataProvider;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you want to log out administration mode?","Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                fLogin flogin = new fLogin();
                this.Hide();
                flogin.Show();
            }
        }

        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you want to log out administration mode?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                fLogin flogin = new fLogin();
                flogin.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void fAdmin_Shown(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            string queryAccounts = "exec USP_GetAccountList ";
            DataTable dataTable = dataProvider.ExecuteQuery(queryAccounts);
            dtgvAccounts.DataSource = dataTable;
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            string queryAccounts = "select ts.fullName, tv.numVote1s as ['Terrible'], tv.numVote2s as ['Bad'], tv.numVote3s as ['Alright'], tv.numVote4s as ['Good'], tv.numVote5s  as ['Excellent'] from TableStaff as ts, TableVoting as tv where ts.staffID = tv.staffID ";
            DataTable dataTable = dataProvider.ExecuteQuery(queryAccounts);
            dtgvVoteMng.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataProvider dataProvider = new DataProvider();
            string queryReset = "update TableVoting set numVote1s = 0, numVote2s = 0, numVote3s = 0, numVote4s = 0, numVote5s = 0 where voteID = 1";
            dataProvider.ExecuteQuery(queryReset);
            string queryAccounts = "select ts.fullName, tv.numVote1s as ['Terrible'], tv.numVote2s as ['Bad'], tv.numVote3s as ['Alright'], tv.numVote4s as ['Good'], tv.numVote5s  as ['Excellent'] from TableStaff as ts, TableVoting as tv where ts.staffID = tv.staffID ";
            DataTable dataTable = dataProvider.ExecuteQuery(queryAccounts);
            dtgvVoteMng.DataSource = dataTable;
        }
    }
}
