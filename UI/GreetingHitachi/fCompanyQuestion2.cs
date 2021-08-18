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
    public partial class fCompanyQuestion2 : Form
    {
        public fCompanyQuestion2()
        {
            InitializeComponent();
        }

        private void fCompanyQuestion_Shown(object sender, EventArgs e)
        {
            string checkString = "";
            if (UserManagement.valueChoice == UserManagement.correctAnswer)
            {
                checkString = "You are right!";
            }
            else
            {
                checkString = "You are wrong!";
            }
            if (UserManagement.showImage == true)
            {
                ptbAnswer.Image = UserManagement.image;
            }
            lbQuestion.Text = checkString + "\n" + UserManagement.ansExplain;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fNewAttendee fnewAttendee = new fNewAttendee();
            this.Hide();
            fnewAttendee.Show();
        }
    }
}
