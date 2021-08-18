using GreetingHitachi;
using GreetingHitachi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fQuestion2 : Form
    {
        public fQuestion2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            fQuestion1 fquestion1 = new fQuestion1();
            fquestion1.StartPosition = this.StartPosition;
            this.Hide();
            fquestion1.Show();
        }

        private void fQuestion2_Shown(object sender, EventArgs e)
        {
            lbQuestion.Text = "Question 1:" + UserManagement.questionContent;
            if (UserManagement.valueChoice == UserManagement.correctAnswer)
            {
                lbCheck.Text = "You are correct!";
            }
            else
            {
                lbCheck.Text = "You are wrong!";
            }
            lbAnswer.Text = "Correct answer: " + UserManagement.correctAnswer;
            if (UserManagement.showImage)
            {
                ptbImage.Image = UserManagement.image;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fCompanyQuestion fcompany = new fCompanyQuestion();
            this.Hide();
            fcompany.Show();
        }
    }
}
