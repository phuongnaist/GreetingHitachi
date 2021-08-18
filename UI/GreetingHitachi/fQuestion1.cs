using GreetingHitachi.DAO;
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
    public partial class fQuestion1 : Form
    {
        public fQuestion1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            fIntro fintro = new fIntro();
            fintro.StartPosition = this.StartPosition;
            this.Hide();
            fintro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fQuestion2 fquestion2 = new fQuestion2();
            fquestion2.StartPosition = this.StartPosition;
            this.Hide();
            fquestion2.Show();
        }

        private void fQuestion1_Shown(object sender, EventArgs e)
        {
            string questionID = UserManagement.random.Next(1, UserManagement.numQuestion).ToString();
            //string questionID = "9";
            DataProvider dataProvider = new DataProvider();
            DataTable dataQuestion = new DataTable();
            dataQuestion = dataProvider.ExecuteQuery("select * from TableQuestions where questionID = " + questionID);
            UserManagement.questionContent = dataQuestion.Rows[0][1].ToString();
            lbQuestionContent.Text = "Question 1:" + UserManagement.questionContent;
            if ((int)dataQuestion.Rows[0][2] == 4)
            {
                UserManagement.showImage = false;
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
                string questionStaffID = UserManagement.random.Next(1, UserManagement.numStaff).ToString();
                DataTable data = new DataTable();
                data = dataProvider.ExecuteQuery("select * from TableStaff as T1, TableDepartments as T2, TableHobbies as T3 where staffID=" + questionStaffID + "and T1.departmentID = T2.departmentID and T1.hobbyID = T3.hobbyID");
                UserManagement.image = Image.FromFile(@"G:\\.shortcut-targets-by-id\\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\\PBL\\Software\\UI\\GreetingHitachi\\Employee_Image\\" + data.Rows[0][9].ToString());
                //ptbImageStaff.Image = Image.FromFile(@".\Employee_Image\\" + dataStaff.Rows[0][9].ToString());
                ptbImageStaff.Image = UserManagement.image;
                UserManagement.showImage = true;
                if ((int)dataQuestion.Rows[0][2] == 1) // DisplayName
                {
                    UserManagement.correctAnswer = data.Rows[0][2].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableStaff as ts where ts.fullname != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer1 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][2].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableStaff as ts where ts.fullname != N'" + UserManagement.wrongAnswer1 + "'and ts.fullname != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer2 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][2].ToString();
                    UserManagement.MixAnswer(UserManagement.answerOrder);
                    if (UserManagement.answerOrder[0] == 3)
                    {
                        UserManagement.dpChoice1 = UserManagement.correctAnswer;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 4)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer1;
                        if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 5)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer2;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                        else if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    lbAnswer1.Text = "1: " + UserManagement.dpChoice1;
                    lbAnswer2.Text = "2: " + UserManagement.dpChoice2;
                    lbAnswer3.Text = "3: " + UserManagement.dpChoice3;
                }
                else if ((int)dataQuestion.Rows[0][2] == 2) // Hobby
                {
                    UserManagement.correctAnswer = data.Rows[0][14].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableHobbies as th where th.hobbyName != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer1 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][1].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableHobbies as th where th.hobbyName != N'" + UserManagement.wrongAnswer1 + "'and th.hobbyName != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer2 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][1].ToString();
                    UserManagement.MixAnswer(UserManagement.answerOrder);

                    if (UserManagement.answerOrder[0] == 3)
                    {
                        UserManagement.dpChoice1 = UserManagement.correctAnswer;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 4)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer1;
                        if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 5)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer2;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                        else if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    lbAnswer1.Text = "1: " + UserManagement.dpChoice1;
                    lbAnswer2.Text = "2: " + UserManagement.dpChoice2;
                    lbAnswer3.Text = "3: " + UserManagement.dpChoice3;
                }
                else if ((int)dataQuestion.Rows[0][2] == 3) // Department
                {
                    UserManagement.correctAnswer = data.Rows[0][12].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableDepartments as td where td.departName != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer1 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][1].ToString();
                    data = dataProvider.ExecuteQuery("select * from TableDepartments as td where td.departName != N'" + UserManagement.wrongAnswer1 + "'and td.departName != N'" + UserManagement.correctAnswer + "'");
                    UserManagement.wrongAnswer2 = data.Rows[(int)UserManagement.random.Next(0, data.Rows.Count - 1)][1].ToString();
                    UserManagement.MixAnswer(UserManagement.answerOrder);
                    if (UserManagement.answerOrder[0] == 3)
                    {
                        UserManagement.dpChoice1 = UserManagement.correctAnswer;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 4)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer1;
                        if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer2;
                        }
                        else if (UserManagement.answerOrder[1] == 5)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer2;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                    }
                    else if (UserManagement.answerOrder[0] == 5)
                    {
                        UserManagement.dpChoice1 = UserManagement.wrongAnswer2;
                        if (UserManagement.answerOrder[1] == 4)
                        {
                            UserManagement.dpChoice2 = UserManagement.wrongAnswer1;
                            UserManagement.dpChoice3 = UserManagement.correctAnswer;
                        }
                        else if (UserManagement.answerOrder[1] == 3)
                        {
                            UserManagement.dpChoice2 = UserManagement.correctAnswer;
                            UserManagement.dpChoice3 = UserManagement.wrongAnswer1;
                        }
                    }
                    lbAnswer1.Text = "1: " + UserManagement.dpChoice1;
                    lbAnswer2.Text = "2: " + UserManagement.dpChoice2;
                    lbAnswer3.Text = "3: " + UserManagement.dpChoice3;
                }
            }
        }

        private void lbAnswer1_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice1;
            this.Hide();
            fQuestion2 fquestion2 = new fQuestion2();
            fquestion2.Show();
        }

        private void lbAnswer2_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice2;
            this.Hide();
            fQuestion2 fquestion2 = new fQuestion2();
            fquestion2.Show();
        }

        private void lbAnswer3_Click(object sender, EventArgs e)
        {
            UserManagement.valueChoice = UserManagement.dpChoice3;
            this.Hide();
            fQuestion2 fquestion2 = new fQuestion2();
            fquestion2.Show();
        }
    }
}
