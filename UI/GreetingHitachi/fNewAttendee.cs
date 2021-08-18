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
    public partial class fNewAttendee : Form
    {
        public fNewAttendee()
        {
            InitializeComponent();
        }

        private void fNewAttendee_Shown(object sender, EventArgs e)
        {
            List<int> personID = new List<int> { };
            List<string> attendingDate = new List<string> { };
            DataProvider dataProvider = new DataProvider();
            DataTable dataTable = new DataTable();
            dataTable = dataProvider.ExecuteQuery("select * from TableStaff");
            for (int i = 0; i<dataTable.Rows.Count; i++)
            {
                attendingDate.Add(dataTable.Rows[i][7].ToString());
                personID.Add((int)dataTable.Rows[i][0]);
            }
            int firstIndex;
            int secondIndex;
            int thirdIndex;
            UserManagement.attendingPersons.attendingDate = attendingDate;
            UserManagement.attendingPersons.personID = personID;
            (firstIndex, secondIndex, thirdIndex) = UserManagement.SortAttending(UserManagement.attendingPersons);
            lbFirstPerson.Text = dataTable.Rows[firstIndex-1][2].ToString() + " \r\n " + dataTable.Rows[firstIndex-1][4].ToString();
            lbSecondPerson.Text = dataTable.Rows[secondIndex - 1][2].ToString() + " \r\n " + dataTable.Rows[secondIndex - 1][4].ToString();
            lbThirdPerson.Text = dataTable.Rows[thirdIndex - 1][2].ToString() + " \r\n " + dataTable.Rows[thirdIndex - 1][4].ToString();
            UserManagement.image = Image.FromFile(@"G:\\.shortcut-targets-by-id\\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\\PBL\\Software\\UI\\GreetingHitachi\\Employee_Image\\"+dataTable.Rows[firstIndex-1][9]);
            ptbPerson1.Image = UserManagement.image;
            UserManagement.image = Image.FromFile(@"G:\\.shortcut-targets-by-id\\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\\PBL\\Software\\UI\\GreetingHitachi\\Employee_Image\\" + dataTable.Rows[secondIndex - 1][9]);
            ptbPerson2.Image = UserManagement.image;
            UserManagement.image = Image.FromFile(@"G:\\.shortcut-targets-by-id\\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\\PBL\\Software\\UI\\GreetingHitachi\\Employee_Image\\" + dataTable.Rows[thirdIndex - 1][9]);
            ptbPerson3.Image = UserManagement.image;
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            fVoting fvoting = new fVoting();
            this.Hide();
            fvoting.Show();
        }
    }
}
