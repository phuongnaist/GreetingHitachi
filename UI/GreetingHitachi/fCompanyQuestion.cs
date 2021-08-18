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
    public partial class fCompanyQuestion : Form
    {
        public fCompanyQuestion()
        {
            InitializeComponent();
        }

        private void fCompanyQuestion_Shown(object sender, EventArgs e)
        {
            string questionID = UserManagement.random.Next(1, UserManagement.numQuestion).ToString();
            //string questionID = "9";
            DataProvider dataProvider = new DataProvider();
            DataTable dataQuestion = new DataTable();
            dataQuestion = dataProvider.ExecuteQuery("select * from TableCompanyQuestions where comQuestionID = " + questionID);
            UserManagement.questionContent = dataQuestion.Rows[0][1].ToString();
            UserManagement.ansExplain = dataQuestion.Rows[0][6].ToString();
            if(questionID!= "6")
            {
                
                if(questionID == "3" || questionID=="4" || questionID=="7" || questionID == "9" || questionID == "10")
                {
                    UserManagement.showImage = true;
                    UserManagement.image = Image.FromFile(@"G:\.shortcut-targets-by-id\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\PBL\Software\SQL\NewProject\FunnyLogin_DataCollection\CompanyEvent_Image\" + "image " + questionID + ".png");
                }
                else
                {
                    UserManagement.showImage = true;
                    UserManagement.image = Image.FromFile(@"G:\.shortcut-targets-by-id\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\PBL\Software\SQL\NewProject\FunnyLogin_DataCollection\CompanyEvent_Image\" + "image " + questionID + ".jpg");
                }
            }
            else
            {
                UserManagement.showImage = false;
            }
            lbQuestion.Text = "Question 2: " + UserManagement.questionContent;
            if ((int)dataQuestion.Rows[0][2] == 1)
            {
                UserManagement.MixAnswer(UserManagement.answerOrder);
                UserManagement.correctAnswer = dataQuestion.Rows[0][3].ToString();
                UserManagement.dpChoice1 = dataQuestion.Rows[0][UserManagement.answerOrder[0]].ToString();
                UserManagement.dpChoice2 = dataQuestion.Rows[0][UserManagement.answerOrder[1]].ToString();
                UserManagement.dpChoice3 = dataQuestion.Rows[0][UserManagement.answerOrder[2]].ToString();
                lbAnswer1.Text = "1: " + UserManagement.dpChoice1;
                lbAnswer2.Text = "2: " + UserManagement.dpChoice2;
                lbAnswer3.Text = "3: " + UserManagement.dpChoice3;
            }
            else
            {
                UserManagement.correctAnswer = "";
                UserManagement.dpChoice1 = "";
                UserManagement.dpChoice2 = "";
                UserManagement.dpChoice3 = "";
                lbAnswer1.Text = "Next";
                lbAnswer2.Text = "";
                lbAnswer3.Text = "";
            }
        }


        private void lbAnswer1_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice1;
            this.Hide();
            fCompanyQuestion2 fcom2 = new fCompanyQuestion2();
            fcom2.Show();
        }

        private void lbAnswer2_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice2;
            this.Hide();
            fCompanyQuestion2 fcom2 = new fCompanyQuestion2();
            fcom2.Show();
        }

        private void lbAnswer3_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice3;
            this.Hide();
            fCompanyQuestion2 fcom2 = new fCompanyQuestion2();
            fcom2.Show();
        }
    }
}
