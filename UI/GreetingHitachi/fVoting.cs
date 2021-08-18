using GreetingHitachi.DAO;
using GreetingHitachi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingHitachi
{
    public partial class fVoting : Form
    {
        DataProvider dataProvider = new DataProvider();
        DataTable dataTable = new DataTable();
        fFinal ffinal = new fFinal();
        public fVoting()
        {
            InitializeComponent();

        }

        private void fVoting_Shown(object sender, EventArgs e)
        {
            dataTable = dataProvider.ExecuteQuery("select * from TableVoting");
            UserManagement.vote1 = (int)dataTable.Rows[0][2];
            UserManagement.vote2 = (int)dataTable.Rows[0][3];
            UserManagement.vote3 = (int)dataTable.Rows[0][4];
            UserManagement.vote4 = (int)dataTable.Rows[0][5];
            UserManagement.vote5 = (int)dataTable.Rows[0][6];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserManagement.vote1++;
            dataProvider.ExecuteQuery("update TableVoting set numVote1s = "+UserManagement.vote1.ToString()+", numVote2s = "+UserManagement.vote2.ToString()+", numVote3s = "+UserManagement.vote3.ToString()+", numVote4s = "+UserManagement.vote4.ToString()+", numVote5s = "+UserManagement.vote5.ToString()+" where voteID = 1");
            this.Hide();
            ffinal.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserManagement.vote2++;
            dataProvider.ExecuteQuery("update TableVoting set numVote1s = " + UserManagement.vote1.ToString() + ", numVote2s = " + UserManagement.vote2.ToString() + ", numVote3s = " + UserManagement.vote3.ToString() + ", numVote4s = " + UserManagement.vote4.ToString() + ", numVote5s = " + UserManagement.vote5.ToString() + " where voteID = 1");
            this.Hide();
            ffinal.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserManagement.vote3++;
            dataProvider.ExecuteQuery("update TableVoting set numVote1s = " + UserManagement.vote1.ToString() + ", numVote2s = " + UserManagement.vote2.ToString() + ", numVote3s = " + UserManagement.vote3.ToString() + ", numVote4s = " + UserManagement.vote4.ToString() + ", numVote5s = " + UserManagement.vote5.ToString() + " where voteID = 1");
            this.Hide();
            ffinal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UserManagement.vote4++;
            dataProvider.ExecuteQuery("update TableVoting set numVote1s = " + UserManagement.vote1.ToString() + ", numVote2s = " + UserManagement.vote2.ToString() + ", numVote3s = " + UserManagement.vote3.ToString() + ", numVote4s = " + UserManagement.vote4.ToString() + ", numVote5s = " + UserManagement.vote5.ToString() + " where voteID = 1");
            this.Hide();
            ffinal.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserManagement.vote5++;
            dataProvider.ExecuteQuery("update TableVoting set numVote1s = " + UserManagement.vote1.ToString() + ", numVote2s = " + UserManagement.vote2.ToString() + ", numVote3s = " + UserManagement.vote3.ToString() + ", numVote4s = " + UserManagement.vote4.ToString() + ", numVote5s = " + UserManagement.vote5.ToString() + " where voteID = 1");
            this.Hide();
            ffinal.Show();
        }
    }
}
