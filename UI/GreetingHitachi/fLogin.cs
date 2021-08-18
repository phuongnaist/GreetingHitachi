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

namespace GreetingSoft
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }



        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you really want to exit the program?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }


 





        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    logInBtn.PerformClick();
                }
        }

        private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                logInBtn.PerformClick();
            }
        }

        private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                logInBtn.PerformClick();
            }
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                logInBtn.PerformClick();
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            fIntro fintro = new fIntro();
            fAdmin fadmin = new fAdmin();
            DataProvider dataProvider = new DataProvider();
            if (txbUserName.Text != "" && txbPassWord.Text != "")
            {

                string queryCheckLogin = "exec USP_CheckLogInAccounts @userName = N'" + txbUserName.Text + "', @passWord = N'" + txbPassWord.Text + "'";
                DataTable checkedData = dataProvider.ExecuteQuery(queryCheckLogin);
                if (checkedData.Rows.Count == 0) // Wrong username or password
                {
                    MessageBox.Show("The User Name or Password is incorrect!", "Notification");
                }
                else if (checkedData.Rows.Count == 1)
                {
                    this.Hide();
                    if ((int)checkedData.Rows[0][0] == 1)
                    {
                        fadmin.Show();
                    }
                    else if ((int)checkedData.Rows[0][0] == 0)
                    {
                        UserManagement.GlobalVar = txbUserName.Text;
                        fintro.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input the login information!", "Notification");
            }
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
